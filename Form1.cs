using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlamFingers
{
    public partial class FrmMain : Form
    {

        string[] mots = { "aatrox", "ahri", "akali", "alistar", "amumu", "anivia", "annie", "aphelios", "ashe", "aurelion sol", "azir", "bard", "blitzcrank", "brand", "braum", "caitlyn", "camille", "cassiopeia", "cho'gath", "corki", "darius", "diana", "draven", "dr mundo", "ekko", "elise", "evelynn", "ezreal", "fiddlesticks", "fiora", "fizz", "galio", "gangplank", "garen", "gnar", "gragas", "graves", "hecarim", "heimerdinger", "illaoi", "irelia", "ivern", "janna", "jarvan iv", "jax", "jayce", "jhin", "jinx", "kai'sa", "kalista", "karma", "karthus", "kassadin", "katarina", "kayle", "kayn", "kennen", "kha'zix", "kindred", "kled", "kog'maw", "leblanc", "lee sin", "leona", "lissandra", "lucian", "lulu", "lux", "maître yi", "malphite", "malzahar", "maokai", "miss fortune", "mordekaiser", "morgana", "nami", "nasus", "nautilus", "neeko", "nidalee", "nocturne", "nunu et willump", "olaf", "orianna", "ornn", "pantheon", "poppy", "pyke", "qiyana", "quinn", "rakan", "rammus", "rek'sai", "renekton", "rengar", "riven", "rumble", "ryze", "sejuani", "senna", "sett", "shaco", "shen", "shyvana", "singed", "sion", "sivir", "skarner", "sona", "soraka", "swain", "sylas", "syndra", "tahm kench", "taliyah", "talon", "taric", "teemo", "thresh", "tristana", "trundle", "tryndamere", "twisted fate", "twitch", "udyr", "urgot", "varus", "vayne", "veigar", "vel'koz", "vi", "viktor", "vladimir", "volibear", "warwick", "wukong", "xayah", "xerath", "xin zhao", "yasuo", "yorick", "yuumi", "zac", "zed", "ziggs", "zilean", "zoé", "zyra" };
        int num = 0;
        int mot;
        int points=0;
        int nbChampions = 148;
        int rand;
        bool[] rando = new bool[148];
        Random random = new Random();
        Timer t = new Timer();
        int countdown = 60;
        public FrmMain()
        {
            InitializeComponent();
            rand = random.Next(0, nbChampions);
            lbMot.Text = mots[rand];
            mot = mots.Length;

            

        }

        private void playGame(object sender, EventArgs e)
        {
            if (lbMot.Text == tBReponse.Text)
            {
                win();
                points += 1;
                lbpoints.Text = "" + points + " mots corrects";
                t.Interval = (60000);
                t.Tick += new EventHandler(t_Tick);
                t.Start();
            }
            
        }

        public void win()
        {

            if (num < mot - 1)
            {
                num++;
                for (int i = 0; i < 1; i++)
                {
                    do
                    {
                        rand = random.Next(0, nbChampions);
                    } while (rando[rand] == true);
                    lbMot.Text = mots[rand];
                    rando[rand] = true;
                }
                tBReponse.Text = "";
                
               
            }
            else
            {
                num = 0;
                lbMot.Text = mots[num];
                tBReponse.Text = "";
            }

        }

        private void BtCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("© 2020 \n Codé par Quentin LACHET. \n ------------------------------------ \n V1.0 \n - Sortie Officielle \n ------------------------------------ \n V1.1 \n - Classement \n ------------------------------------ \n V1.2.1 \n - Randomization ", "Slam Fingers");
        }

        private void t_Tick(object sender, EventArgs e)
        {
            countdown--;
            if (countdown < 1)
            {
                countdown = 60;
            }
            lbCountdown.Text = countdown.ToString();
            t.Stop();
            MessageBox.Show("Terminé ! Vous avez " + points + " mots correct en 1 minute.","Slam Fingers");
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Adam : 62 \n2.Quentin : 53 \n3.Francis : 47 \n4.Anthony : 40 \n5.Stephen : 31 \n6.Vinushan : 25 \n7.Hugo : 24 \n7.Sabri : 24 \n9.Jean - Lou : 20 \n9.Kantécar : 20", "Slam Fingers");
        }
    }
}
