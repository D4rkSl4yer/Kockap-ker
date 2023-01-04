using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kockapóker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string[] kategoria = { "egyesek", "kettesek", "hármasok", "négyesek", "ötösök", "hatosok", "egy pár", "két pár", "terc", "póker", "yahtzee", "kis sor", "nagy sor", "full", "összeg","eredmény" };
        public int kor = 0;
        jatekosok jatekos1 = new jatekosok();
        jatekosok jatekos2 = new jatekosok();

        public int[] dobasok = { 0, 0, 0, 0, 0};
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < kategoria.Length; i++)
            {
                tabla_dgv.Rows.Add(kategoria[i], "", "");
            }
            jatekosvaltas();
        }

        private void jatekosvaltas()
        {
            torol();
            kiir();
            #region
            if (Jatekos_l.Text=="Játékos 1")
            {
                Jatekos_l.Text = "Játékos 2";
            }
            else if (Jatekos_l.Text == "Játékos 2")
            {
                Jatekos_l.Text = "Játékos 1";
            }
            else
            {
                Jatekos_l.Text = "Játékos 1";
            }
            dobas1_l.Text = $"0";
            dobas2_l.Text = $"0";
            dobas3_l.Text = $"0";
            dobas4_l.Text = $"0";
            dobas5_l.Text = $"0";
            #endregion
            kor++;
            kor_l.Text = $"{kor/2}. kör";
            if (kor==31)
            {
                Environment.Exit(1);
            }
        }

        private void dobas_btn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            dobasok[0] = rnd.Next(1, 6);
            dobasok[1] = rnd.Next(1, 6);
            dobasok[2] = rnd.Next(1, 6);
            dobasok[3] = rnd.Next(1, 6);
            dobasok[4] = rnd.Next(1, 6);
            dobas1_l.Text = $"{dobasok[0]}";
            dobas2_l.Text = $"{dobasok[1]}";
            dobas3_l.Text = $"{dobasok[2]}";
            dobas4_l.Text = $"{dobasok[3]}";
            dobas5_l.Text = $"{dobasok[4]}";
            ertekeles();
        }

        private void ertekeles()
        {
            torol();
            for (int i = 0; i < tabla_dgv.Rows.Count-1; i++)
            {
                    tabla_dgv.Rows[i].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[i].Cells[1].Value = "";
            }
            if (Jatekos_l.Text== "Játékos 1")
            {
                #region
                if (dobasok.Contains(1))
                {
                    if (tabla_dgv.Rows[0].Cells[1].Value=="")
                    {
                        tabla_dgv.Rows[0].Cells[1].Style.ForeColor = Color.Green;
                        tabla_dgv.Rows[0].Cells[1].Value = $"{dobasok.Where(x=>x==1).Sum()}";
                    }
                }
                if (dobasok.Contains(2))
                {
                    if (tabla_dgv.Rows[1].Cells[1].Value == "")
                    {
                        tabla_dgv.Rows[1].Cells[1].Style.ForeColor = Color.Green;
                        tabla_dgv.Rows[1].Cells[1].Value = $"{dobasok.Where(x => x == 2).Sum()}";
                    }
                }
                if (dobasok.Contains(3))
                {
                    if (tabla_dgv.Rows[2].Cells[1].Value == "")
                    {
                        tabla_dgv.Rows[2].Cells[1].Style.ForeColor = Color.Green;
                        tabla_dgv.Rows[2].Cells[1].Value = $"{dobasok.Where(x => x == 3).Sum()}";
                    }
                }
                if (dobasok.Contains(4))
                {
                    if (tabla_dgv.Rows[3].Cells[1].Value == "")
                    {
                        tabla_dgv.Rows[3].Cells[1].Style.ForeColor = Color.Green;
                        tabla_dgv.Rows[3].Cells[1].Value = $"{dobasok.Where(x => x == 4).Sum()}";
                    }
                }
                if (dobasok.Contains(5))
                {
                    if (tabla_dgv.Rows[4].Cells[1].Value == "")
                    {
                        tabla_dgv.Rows[4].Cells[1].Style.ForeColor = Color.Green;
                        tabla_dgv.Rows[4].Cells[1].Value = $"{dobasok.Where(x => x == 5).Sum()}";
                    }
                }
                if (dobasok.Contains(6))
                {
                    if (tabla_dgv.Rows[5].Cells[1].Value == "")
                    {
                        tabla_dgv.Rows[5].Cells[1].Style.ForeColor = Color.Green;
                        tabla_dgv.Rows[5].Cells[1].Value = $"{dobasok.Where(x => x == 6).Sum()}";
                    }
                }
                int[] osszesit = new int[5];
                for (int i = 0; i < osszesit.Length; i++)
                {
                    for (int k = 0; k < dobasok.Length; k++)
                    {
                        if (i+1==dobasok[k])
                        {
                            osszesit[i]++;
                        }
                    }
                }
                //yahtzee
                
                if (osszesit[0]==5)
                {
                        tabla_dgv.Rows[10].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[10].Cells[1].Value = $"50";
                }
                if (osszesit[1] == 5)
                {
                    tabla_dgv.Rows[10].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[10].Cells[1].Value = $"50";
                }
                if (osszesit[2] == 5)
                {
                    tabla_dgv.Rows[10].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[10].Cells[1].Value = $"50";
                }
                if (osszesit[3] == 5)
                {
                    tabla_dgv.Rows[10].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[10].Cells[1].Value = $"50";
                }
                if (osszesit[4] == 5)
                {
                    tabla_dgv.Rows[10].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[10].Cells[1].Value = $"50";
                }
                //póker
                
                if (osszesit[4] == 4)
                {
                    tabla_dgv.Rows[9].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[9].Cells[1].Value = $"20";
                }
                else if (osszesit[3] == 4)
                {
                    tabla_dgv.Rows[9].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[9].Cells[1].Value = $"16";
                }
                else if (osszesit[2] == 4)
                {
                    tabla_dgv.Rows[9].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[9].Cells[1].Value = $"12";
                }
                else if (osszesit[1] == 4)
                {
                    tabla_dgv.Rows[9].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[9].Cells[1].Value = $"8";
                }
                else if (osszesit[0] == 4)
                {
                    tabla_dgv.Rows[9].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[9].Cells[1].Value = $"4";
                }
                //terc
                
                if (osszesit[4] == 3)
                {
                    tabla_dgv.Rows[8].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[8].Cells[1].Value = $"15";
                }
                else if (osszesit[3] == 3)
                {
                    tabla_dgv.Rows[8].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[8].Cells[1].Value = $"12";
                }
                else if (osszesit[2] == 3)
                {
                    tabla_dgv.Rows[8].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[8].Cells[1].Value = $"9";
                }
                else if (osszesit[1] == 3)
                {
                    tabla_dgv.Rows[8].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[8].Cells[1].Value = $"6";
                }
                else if (osszesit[0] == 3)
                {
                    tabla_dgv.Rows[8].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[8].Cells[1].Value = $"3";
                }
                //két pár
                Array.Sort(osszesit);
                Array.Reverse(osszesit);
                for (int i = 0; i < osszesit.Length-1; i++)
                {
                    if (osszesit[i] == 2)
                    {
                        for (int j = i+1; j < osszesit.Length; j++)
                        {
                            if (osszesit[j] == 2)
                            {
                                tabla_dgv.Rows[7].Cells[1].Style.ForeColor = Color.Green;
                                tabla_dgv.Rows[7].Cells[1].Value = $"{(i + 1 + j + 1) * 2}";
                                break;
                            }
                        }
                        break;
                    }
                }
                //egy pár
                for (int i = 0; i < osszesit.Length; i++)
                {
                    if (osszesit[i] == 2)
                    {
                        tabla_dgv.Rows[6].Cells[1].Style.ForeColor = Color.Green;
                        tabla_dgv.Rows[6].Cells[1].Value = $"{(i + 1) * 2}";
                        break;
                    }
                }
                //kis sor
                if (dobasok.Contains(1) && dobasok.Contains(2) && dobasok.Contains(3) && dobasok.Contains(4))
                {
                    tabla_dgv.Rows[11].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[11].Cells[1].Value = $"30";
                }
                else if (dobasok.Contains(2) && dobasok.Contains(3) && dobasok.Contains(4) && dobasok.Contains(5))
                {
                    tabla_dgv.Rows[11].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[11].Cells[1].Value = $"30";
                }
                else if (dobasok.Contains(3) && dobasok.Contains(4) && dobasok.Contains(5) && dobasok.Contains(6))
                {
                    tabla_dgv.Rows[11].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[11].Cells[1].Value = $"30";
                }
                //nagy sor
                if (dobasok.Contains(1) && dobasok.Contains(2) && dobasok.Contains(3) && dobasok.Contains(4) && dobasok.Contains(5))
                {
                    tabla_dgv.Rows[12].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[12].Cells[1].Value = $"40";
                }
                else if (dobasok.Contains(6) && dobasok.Contains(2) && dobasok.Contains(3) && dobasok.Contains(4) && dobasok.Contains(5))
                {
                    tabla_dgv.Rows[12].Cells[1].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[12].Cells[1].Value = $"40";
                }
                //full
                for (int i = 0; i < dobasok.Length; i++)
                {
                    if (dobasok[i]==3)
                    {
                        for (int j = 0; j < dobasok.Length; j++)
                        {
                            if (dobasok[i]==2)
                            {
                                tabla_dgv.Rows[13].Cells[1].Style.ForeColor = Color.Green;
                                tabla_dgv.Rows[13].Cells[1].Value = $"25";
                            }
                        }
                    }
                }
                //osszeg
                tabla_dgv.Rows[14].Cells[1].Style.ForeColor = Color.Green;
                tabla_dgv.Rows[14].Cells[1].Value = $"{dobasok.Sum()}";
                #endregion

            }
            else
            {
                #region
                for (int i = 0; i < tabla_dgv.Rows.Count; i++)
                {
                    tabla_dgv.Rows[i].Cells[2].Style.ForeColor = Color.Green;
                    tabla_dgv.Rows[i].Cells[2].Value = "";
                }
                if (dobasok.Contains(1))
                {
                    if (tabla_dgv.Rows[0].Cells[2].Value == "")
                    {
                        tabla_dgv.Rows[0].Cells[2].Value = $"{dobasok.Where(x => x == 1).Sum()}";
                    }
                }
                if (dobasok.Contains(2))
                {
                    if (tabla_dgv.Rows[1].Cells[2].Value == "")
                    {
                        tabla_dgv.Rows[1].Cells[2].Value = $"{dobasok.Where(x => x == 2).Sum()}";
                    }
                }
                if (dobasok.Contains(3))
                {
                    if (tabla_dgv.Rows[2].Cells[2].Value == "")
                    {
                        tabla_dgv.Rows[2].Cells[2].Value = $"{dobasok.Where(x => x == 3).Sum()}";
                    }
                }
                if (dobasok.Contains(4))
                {
                    if (tabla_dgv.Rows[3].Cells[2].Value == "")
                    {
                        tabla_dgv.Rows[3].Cells[2].Value = $"{dobasok.Where(x => x == 4).Sum()}";
                    }
                }
                if (dobasok.Contains(5))
                {
                    if (tabla_dgv.Rows[4].Cells[2].Value == "")
                    {
                        tabla_dgv.Rows[4].Cells[2].Value = $"{dobasok.Where(x => x == 5).Sum()}";
                    }
                }
                if (dobasok.Contains(6))
                {
                    if (tabla_dgv.Rows[5].Cells[2].Value == "")
                    {
                        tabla_dgv.Rows[5].Cells[2].Value = $"{dobasok.Where(x => x == 6).Sum()}";
                    }
                }
                int[] osszesit = new int[5];
                for (int i = 0; i < osszesit.Length; i++)
                {
                    for (int k = 0; k < dobasok.Length; k++)
                    {
                        if (i + 1 == dobasok[k])
                        {
                            osszesit[i]++;
                        }
                    }
                }
                //yahtzee

                if (osszesit[0] == 5)
                {
                    tabla_dgv.Rows[10].Cells[2].Value = $"50";
                }
                if (osszesit[1] == 5)
                {
                    tabla_dgv.Rows[10].Cells[2].Value = $"50";
                }
                if (osszesit[2] == 5)
                {
                    tabla_dgv.Rows[10].Cells[2].Value = $"50";
                }
                if (osszesit[3] == 5)
                {
                    tabla_dgv.Rows[10].Cells[2].Value = $"50";
                }
                if (osszesit[4] == 5)
                {
                    tabla_dgv.Rows[10].Cells[2].Value = $"50";
                }
                //póker

                if (osszesit[4] == 4)
                {
                    tabla_dgv.Rows[9].Cells[2].Value = $"20";
                }
                else if (osszesit[3] == 4)
                {
                    tabla_dgv.Rows[9].Cells[2].Value = $"16";
                }
                else if (osszesit[2] == 4)
                {
                    tabla_dgv.Rows[9].Cells[2].Value = $"12";
                }
                else if (osszesit[1] == 4)
                {
                    tabla_dgv.Rows[9].Cells[2].Value = $"8";
                }
                else if (osszesit[0] == 4)
                {
                    tabla_dgv.Rows[9].Cells[2].Value = $"4";
                }
                //terc

                if (osszesit[4] == 3)
                {
                    tabla_dgv.Rows[8].Cells[2].Value = $"15";
                }
                else if (osszesit[3] == 3)
                {
                    tabla_dgv.Rows[8].Cells[2].Value = $"12";
                }
                else if (osszesit[2] == 3)
                {
                    tabla_dgv.Rows[8].Cells[2].Value = $"9";
                }
                else if (osszesit[1] == 3)
                {
                    tabla_dgv.Rows[8].Cells[2].Value = $"6";
                }
                else if (osszesit[0] == 3)
                {
                    tabla_dgv.Rows[8].Cells[2].Value = $"3";
                }
                //két pár
                Array.Sort(osszesit);
                Array.Reverse(osszesit);
                for (int i = 0; i < osszesit.Length - 1; i++)
                {
                    if (osszesit[i] == 2)
                    {
                        for (int j = i + 1; j < osszesit.Length; j++)
                        {
                            if (osszesit[j] == 2)
                            {
                                tabla_dgv.Rows[7].Cells[2].Value = $"{(i + 1 + j + 1) * 2}";
                                break;
                            }
                        }
                        break;
                    }
                }
                //egy pár
                for (int i = 0; i < osszesit.Length; i++)
                {
                    if (osszesit[i] == 2)
                    {
                        tabla_dgv.Rows[6].Cells[2].Value = $"{(i + 1) * 2}";
                        break;
                    }
                }
                //kis sor
                if (dobasok.Contains(1) && dobasok.Contains(2) && dobasok.Contains(3) && dobasok.Contains(4))
                {
                    tabla_dgv.Rows[11].Cells[2].Value = $"30";
                }
                else if (dobasok.Contains(2) && dobasok.Contains(3) && dobasok.Contains(4) && dobasok.Contains(5))
                {
                    tabla_dgv.Rows[11].Cells[2].Value = $"30";
                }
                else if (dobasok.Contains(3) && dobasok.Contains(4) && dobasok.Contains(5) && dobasok.Contains(6))
                {
                    tabla_dgv.Rows[11].Cells[2].Value = $"30";
                }
                //nagy sor
                if (dobasok.Contains(1) && dobasok.Contains(2) && dobasok.Contains(3) && dobasok.Contains(4) && dobasok.Contains(5))
                {
                    tabla_dgv.Rows[12].Cells[2].Value = $"40";
                }
                else if (dobasok.Contains(6) && dobasok.Contains(2) && dobasok.Contains(3) && dobasok.Contains(4) && dobasok.Contains(5))
                {
                    tabla_dgv.Rows[12].Cells[2].Value = $"40";
                }
                //full
                for (int i = 0; i < dobasok.Length; i++)
                {
                    if (dobasok[i] == 3)
                    {
                        for (int j = 0; j < dobasok.Length; j++)
                        {
                            if (dobasok[i] == 2)
                            {
                                tabla_dgv.Rows[13].Cells[2].Value = $"25";
                            }
                        }
                    }
                }
                //osszeg
                tabla_dgv.Rows[14].Cells[2].Value = $"{dobasok.Sum()}";
                #endregion
            }
            kiir();
        }

        private void torol()
        {
            for (int i = 0; i < tabla_dgv.Rows.Count; i++)
            {
                tabla_dgv.Rows[i].Cells[1].Value = null;
                tabla_dgv.Rows[i].Cells[1].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[i].Cells[2].Value = null;
                tabla_dgv.Rows[i].Cells[2].Style.ForeColor = Color.Black;
            }
        }

        private void kiir()
        {
            if (jatekos1.egyesek!=0)
            {
                tabla_dgv.Rows[0].Cells[1].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[0].Cells[1].Value = jatekos1.egyesek;
            }
            if (jatekos1.kettesek != 0)
            {
                tabla_dgv.Rows[1].Cells[1].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[1].Cells[1].Value = jatekos1.kettesek;
            }
            if (jatekos1.harmasok != 0)
            {
                tabla_dgv.Rows[2].Cells[1].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[2].Cells[1].Value = jatekos1.harmasok;
            }
            if (jatekos1.negyesek != 0)
            {
                tabla_dgv.Rows[3].Cells[1].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[3].Cells[1].Value = jatekos1.negyesek;
            }
            if (jatekos1.otosok != 0)
            {
                tabla_dgv.Rows[4].Cells[1].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[4].Cells[1].Value = jatekos1.otosok;
            }
            if (jatekos1.hatosok != 0)
            {
                tabla_dgv.Rows[5].Cells[1].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[5].Cells[1].Value = jatekos1.hatosok;
            }
            if (jatekos1.egypar != 0)
            {
                tabla_dgv.Rows[6].Cells[1].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[6].Cells[1].Value = jatekos1.egypar;
            }
            if (jatekos1.ketpar != 0)
            {
                tabla_dgv.Rows[7].Cells[1].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[7].Cells[1].Value = jatekos1.ketpar;
            }
            if (jatekos1.terc != 0)
            {
                tabla_dgv.Rows[8].Cells[1].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[8].Cells[1].Value = jatekos1.terc;
            }
            if (jatekos1.poker != 0)
            {
                tabla_dgv.Rows[9].Cells[1].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[9].Cells[1].Value = jatekos1.poker;
            }
            if (jatekos1.yahtzee != 0)
            {
                tabla_dgv.Rows[10].Cells[1].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[10].Cells[1].Value = jatekos1.yahtzee;
            }
            if (jatekos1.kissor != 0)
            {
                tabla_dgv.Rows[11].Cells[1].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[11].Cells[1].Value = jatekos1.kissor;
            }
            if (jatekos1.nagysor != 0)
            {
                tabla_dgv.Rows[12].Cells[1].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[12].Cells[1].Value = jatekos1.nagysor;
            }
            if (jatekos1.full != 0)
            {
                tabla_dgv.Rows[13].Cells[1].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[13].Cells[1].Value = jatekos1.full;
            }
            if (jatekos1.összeg != 0)
            {
                tabla_dgv.Rows[14].Cells[1].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[14].Cells[1].Value = jatekos1.összeg;
            }


            if (jatekos2.egyesek != 0)
            {
                tabla_dgv.Rows[0].Cells[2].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[0].Cells[2].Value = jatekos2.egyesek;
            }
            if (jatekos2.kettesek != 0)
            {
                tabla_dgv.Rows[1].Cells[2].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[1].Cells[2].Value = jatekos2.kettesek;
            }
            if (jatekos2.harmasok != 0)
            {
                tabla_dgv.Rows[2].Cells[2].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[2].Cells[2].Value = jatekos2.harmasok;
            }
            if (jatekos2.negyesek != 0)
            {
                tabla_dgv.Rows[3].Cells[2].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[3].Cells[2].Value = jatekos2.negyesek;
            }
            if (jatekos2.otosok != 0)
            {
                tabla_dgv.Rows[4].Cells[2].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[4].Cells[2].Value = jatekos2.otosok;
            }
            if (jatekos2.hatosok != 0)
            {
                tabla_dgv.Rows[5].Cells[2].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[5].Cells[2].Value = jatekos2.hatosok;
            }
            if (jatekos2.egypar != 0)
            {
                tabla_dgv.Rows[6].Cells[2].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[6].Cells[2].Value = jatekos2.egypar;
            }
            if (jatekos2.ketpar != 0)
            {
                tabla_dgv.Rows[7].Cells[2].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[7].Cells[2].Value = jatekos2.ketpar;
            }
            if (jatekos2.terc != 0)
            {
                tabla_dgv.Rows[8].Cells[2].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[8].Cells[2].Value = jatekos2.terc;
            }
            if (jatekos2.poker != 0)
            {
                tabla_dgv.Rows[9].Cells[2].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[9].Cells[2].Value = jatekos2.poker;
            }
            if (jatekos2.yahtzee != 0)
            {
                tabla_dgv.Rows[10].Cells[2].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[10].Cells[2].Value = jatekos2.yahtzee;
            }
            if (jatekos2.kissor != 0)
            {
                tabla_dgv.Rows[11].Cells[2].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[11].Cells[2].Value = jatekos2.kissor;
            }
            if (jatekos2.nagysor != 0)
            {
                tabla_dgv.Rows[12].Cells[2].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[12].Cells[2].Value = jatekos2.nagysor;
            }
            if (jatekos2.full != 0)
            {
                tabla_dgv.Rows[13].Cells[2].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[13].Cells[2].Value = jatekos2.full;
            }
            if (jatekos2.összeg != 0)
            {
                tabla_dgv.Rows[14].Cells[2].Style.ForeColor = Color.Black;
                tabla_dgv.Rows[14].Cells[2].Value = jatekos2.összeg;
            }

            int eredmeny = jatekos1.egyesek+jatekos1.kettesek+jatekos1.harmasok+jatekos1.negyesek+jatekos1.negyesek+jatekos1.otosok+jatekos1.hatosok+jatekos1.egypar+jatekos1.ketpar+jatekos1.terc+jatekos1.poker+jatekos1.yahtzee+jatekos1.kissor+jatekos1.nagysor+jatekos1.full+jatekos1.összeg;
            int eredmeny2= jatekos2.egyesek + jatekos2.kettesek + jatekos2.harmasok + jatekos2.negyesek + jatekos2.negyesek + jatekos2.otosok + jatekos2.hatosok + jatekos2.egypar + jatekos2.ketpar + jatekos2.terc + jatekos2.poker + jatekos2.yahtzee + jatekos2.kissor + jatekos2.nagysor + jatekos2.full + jatekos2.összeg;
            tabla_dgv.Rows[15].Cells[1].Value = eredmeny;
            tabla_dgv.Rows[15].Cells[2].Value = eredmeny2;

            if (eredmeny > eredmeny2)
            {
                tabla_dgv.Rows[15].Cells[1].Style.ForeColor = Color.Green;
                tabla_dgv.Rows[15].Cells[2].Style.ForeColor = Color.Red;

            }
            else if (eredmeny == eredmeny2)
            {
                tabla_dgv.Rows[15].Cells[1].Style.ForeColor = Color.Yellow;
                tabla_dgv.Rows[15].Cells[2].Style.ForeColor = Color.Yellow;
            }
            else
            {
                tabla_dgv.Rows[15].Cells[1].Style.ForeColor = Color.Red;
                tabla_dgv.Rows[15].Cells[2].Style.ForeColor = Color.Green;
            }
        }
            

        private void tabla_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla_dgv.CurrentCell.Value!=null)
            {
                if (tabla_dgv.CurrentCell.ColumnIndex == 1)
                {
                    switch (tabla_dgv.CurrentCell.RowIndex)
                    {
                        case 0:
                            if (jatekos1.egyesek == 0)
                            {
                                jatekos1.egyesek = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }

                            break;
                        case 1:
                            if (jatekos1.kettesek == 0)
                            {
                                jatekos1.kettesek = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 2:
                            if (jatekos1.harmasok == 0)
                            {
                                jatekos1.harmasok = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 3:
                            if (jatekos1.negyesek == 0)
                            {
                                jatekos1.negyesek = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 4:
                            if (jatekos1.otosok == 0)
                            {
                                jatekos1.otosok = int.Parse(tabla_dgv.CurrentCell.Value.ToString());

                            }
                            break;
                        case 5:
                            if (jatekos1.hatosok == 0)
                            {
                                jatekos1.hatosok = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 6:
                            if (jatekos1.egypar == 0)
                            {
                                jatekos1.egypar = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 7:
                            if (jatekos1.ketpar == 0)
                            {
                                jatekos1.ketpar = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 8:
                            if (jatekos1.terc == 0)
                            {
                                jatekos1.terc = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 9:
                            if (jatekos1.poker == 0)
                            {
                                jatekos1.poker = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 10:
                            if (jatekos1.yahtzee == 0)
                            {
                                jatekos1.yahtzee = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 11:
                            if (jatekos1.kissor == 0)
                            {
                                jatekos1.kissor = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 12:
                            if (jatekos1.nagysor == 0)
                            {
                                jatekos1.nagysor = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 13:
                            if (jatekos1.full == 0)
                            {
                                jatekos1.full = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 14:
                            if (jatekos1.összeg == 0)
                            {
                                jatekos1.összeg = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                    }
                }
                else if (tabla_dgv.CurrentCell.ColumnIndex == 2)
                {
                    switch (tabla_dgv.CurrentCell.RowIndex)
                    {
                        case 0:
                            if (jatekos2.egyesek == 0)
                            {
                                jatekos2.egyesek = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }

                            break;
                        case 1:
                            if (jatekos2.kettesek == 0)
                            {
                                jatekos2.kettesek = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 2:
                            if (jatekos2.harmasok == 0)
                            {
                                jatekos2.harmasok = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 3:
                            if (jatekos2.negyesek == 0)
                            {
                                jatekos2.negyesek = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 4:
                            if (jatekos2.otosok == 0)
                            {
                                jatekos2.otosok = int.Parse(tabla_dgv.CurrentCell.Value.ToString());

                            }
                            break;
                        case 5:
                            if (jatekos2.hatosok == 0)
                            {
                                jatekos2.hatosok = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 6:
                            if (jatekos2.egypar == 0)
                            {
                                jatekos2.egypar = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 7:
                            if (jatekos2.ketpar == 0)
                            {
                                jatekos2.ketpar = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 8:
                            if (jatekos2.terc == 0)
                            {
                                jatekos2.terc = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 9:
                            if (jatekos2.poker == 0)
                            {
                                jatekos2.poker = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 10:
                            if (jatekos2.yahtzee == 0)
                            {
                                jatekos2.yahtzee = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 11:
                            if (jatekos2.kissor == 0)
                            {
                                jatekos2.kissor = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 12:
                            if (jatekos2.nagysor == 0)
                            {
                                jatekos2.nagysor = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 13:
                            if (jatekos2.full == 0)
                            {
                                jatekos2.full = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                        case 14:
                            if (jatekos2.összeg == 0)
                            {
                                jatekos2.összeg = int.Parse(tabla_dgv.CurrentCell.Value.ToString());
                            }
                            break;
                    }
                }
            }
            jatekosvaltas();
        }
    }
}
