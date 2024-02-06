using Restaurant.DAO;
using Restaurant.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class RestaurantVerwaltungfenster : Form
    {
        public RestaurantVerwaltungfenster()
        {
            InitializeComponent();
            TischLaden();
            KategorieLaden();
        }

        private void TischLaden()
        {
            flpTische.Controls.Clear();
            List<Tisch> tischList = TischDAO.Instance.TischLaden();
            foreach (Tisch t in tischList)
            {
                Button btn = new Button() { Width = TischDAO.tischWidth, Height = TischDAO.tischHeight};
                btn.Text = $"{t.Name} \n {t.Status}";
                btn.Click += btn_Click;
                btn.Tag = t;
                switch (t.Status)
                {
                    case "frei":
                        btn.BackColor = Color.LimeGreen;
                        break;
                    default:
                        btn.BackColor = Color.OrangeRed;
                        break;
                }

                flpTische.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int tischId = ((sender as Button).Tag as Tisch).ID;
            lvRechnung.Tag = (sender as Button).Tag;
            RechnungAnzeige(tischId);
        }

        private void RechnungAnzeige(int tischId)
        {
            lvRechnung.Items.Clear();
            List<Restaurant.DTO.Menu> listRechnungInfo = MenuDAO.Instance.GetListMenuByTable(tischId);
            float preis = 0;
            foreach(Restaurant.DTO.Menu item in listRechnungInfo)
            {
                ListViewItem listViewItem = new ListViewItem(item.FoodName.ToString());
                listViewItem.SubItems.Add(item.Count.ToString());
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(item.TotelPrice.ToString());
                lvRechnung.Items.Add(listViewItem);
                preis += item.TotelPrice;
            }
            CultureInfo culture = new CultureInfo("de-DE");
            tbGesammterPreis.Text = preis.ToString("c",culture); 
        } 
        private void auslogenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void persönlicheInfomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KontoInfofenster kontoInfofenster = new KontoInfofenster();
            kontoInfofenster.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adminfenster adminfenster = new Adminfenster();
            adminfenster.ShowDialog();
        }

        private void KategorieLaden()
        {
            List<Kategorie> listKategorie = KategorieDAO.Instance.GetListKategorie();
            cbKatagorie.DataSource = listKategorie;
            cbKatagorie.DisplayMember = "Name";
        }

        private void SpeisenNachKategorieIdLaden(int id)
        {
            List<Speisen> listSpeisen = SpeisenDAO.Instance.GetListSpeisenNachKategorieId(id);
            cbSpeisen.DataSource = listSpeisen;
            cbSpeisen.DisplayMember = "Name";
        }

        private void cbKatagorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedItem == null)
            {
                return;
            }
            Kategorie kategorie = cb.SelectedItem as Kategorie;
            id = kategorie.Id;

            SpeisenNachKategorieIdLaden(id);
        }

        private void btnSpeisenHinzufuegen_Click(object sender, EventArgs e)
        {
            Tisch tisch = lvRechnung.Tag as Tisch;
            int idRechnung = RechnungDAO.Instance.GetUncheckBillByTableId(tisch.ID);
            int idSpeisen = (cbSpeisen.SelectedItem as Speisen).Id;
            int anzahl = (int)nudSpeisenAnzahl.Value;

            if(idRechnung == -1)
            {
                RechnungDAO.Instance.InsertBill(tisch.ID);
                RechnungInfoDAO.Instance.InsertBillInfo(RechnungDAO.Instance.GetMaxIdBill(),idSpeisen,anzahl);
                
            }
            else
            {
                RechnungInfoDAO.Instance.InsertBillInfo(idRechnung,idSpeisen,anzahl);
            }
            RechnungAnzeige(tisch.ID);
            TischLaden();
        }

        private void btnZahlung_Click(object sender, EventArgs e)
        {
            Tisch tisch = lvRechnung.Tag as Tisch;
            int idRechnung = RechnungDAO.Instance.GetUncheckBillByTableId(tisch.ID);
            int rabatt = (int)nudRabatt.Value;
            float gesammteBetrag = float.Parse(tbGesammterPreis.Text.Replace("€", "").Replace(",", "."), CultureInfo.InvariantCulture);
            if (idRechnung != -1)
            {
                if(MessageBox.Show($"Gesammte Betrag: {(float)(gesammteBetrag - gesammteBetrag*rabatt/100)} euro","Meldung",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    RechnungDAO.Instance.CheckOut(idRechnung,rabatt);
                    RechnungAnzeige(tisch.ID);
                    TischLaden();
                }
            }
        }
    }
}
