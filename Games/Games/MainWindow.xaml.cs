using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Games
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> platforms = new List<string>();
        public MainWindow()
        {
            InitializeComponent();

            string[] lines = File.ReadAllLines("all_games.csv");

            for (int i = 1; i < lines.Length; i++)
            {
                string[] pieces = lines[i].Split(',');
                Game g = new Game();
                g.name = pieces[0];
                g.platform = pieces[1];
                g.release_date = pieces[2];
                g.summary = pieces[3];
                g.meta_score = pieces[4];
                g.user_review = pieces[5];
                if (GamesCbo.Items.Contains(g.platform) == false)
                {
                    GamesCbo.Items.Add(g.platform);
                }
            }
        }
    }
}
