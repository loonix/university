using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace WPF_Philosophers
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        enum CardChangeDirection
        {
            UP, DOWN
        }

        public List<Philosopher> philosophers = new List<Philosopher>();
        double fadeouttime = 500;
        double rotationouttime = 500;
        double fadeintime = 400;
        double rotationintime = 400;
        CardChangeDirection theDirection = CardChangeDirection.DOWN;


        public int AnimInFromAngle
        {
            get
            {
                int angle = 0;
                switch (theDirection)
                {
                    case CardChangeDirection.UP: angle = 0; break;
                    case CardChangeDirection.DOWN: angle = 0; break;
                }
                return angle;
            }
        }

        public int AnimInToAngle
        {
            get
            {
                int angle = 0;
                switch (theDirection)
                {
                    case CardChangeDirection.UP: angle = -90; break;
                    case CardChangeDirection.DOWN: angle = 90; break;
                }
                return angle;
            }
        }

        public int AnimOutFromAngle
        {
            get
            {
                int angle = 0;
                switch (theDirection)
                {
                    case CardChangeDirection.UP: angle = 90; break;
                    case CardChangeDirection.DOWN: angle = -90; break;
                }
                return angle;
            }
        }

        public int AnimOutToAngle
        {
            get
            {
                int angle = 0;
                switch (theDirection)
                {
                    case CardChangeDirection.UP: angle = 0; break;
                    case CardChangeDirection.DOWN: angle = 0; break;
                }
                return angle;
            }
        }

        public Window1()
        {
            InitializeComponent();
            CreatePhilosopherList();
            CreateMenuItems();
            list.DataContext = philosophers;
            this.philoPresenter.DataContext = philosophers[0];
            MenuItem mi = ((MenuItem)this.menu1.Items[0]);
         
            for(int i=0; i<mi.Items.Count; i++) 
            {
                MenuItem m = mi.Items.GetItemAt(i) as MenuItem;
                if (m.Header.ToString() == philosophers[0].Name)
                {
                    m.IsChecked = true;
                    break;
                }
            }
        }

        void CreatePhilosopherList()
        {
            Philosopher cc = new Philosopher { 
                Name = "Rudolf Steiner",
                DoB = 1861, 
                DoP = 1925,
                Nationality = "Germany"};
            cc.ImageName = "Steiner.jpg";
            cc.Quote = "Knowledge of life in the astral world leads us to a conclusion of fundamental importance, namely that the physical world is the product of the astral world. ";
            cc.Thesis = "Philosopher, literary scholar, educator, artist, playwright, social thinker, and esotericist. " +
                "Founder of Anthroposophy, Waldorf School, Biodynamic Farming, Threefold social order and Christian Community (indirectly). " +
                "Based much on Goethe and criticized Kant. Steiner denies the division between faith and knowledge (or spiritual and natural worlds). ";
            philosophers.Add(cc);

            cc = new Philosopher
            {
                Name = "J.W. von Goethe",
                DoB = 1749,
                DoP = 1832,
                Nationality = "Germany"
            };
            cc.ImageName = "Goethe.png";
            cc.Quote = "A person hears only what they understand.";
            cc.Thesis = "Johann Wolfgang von Goethe was a german philosopher and writer. His most famous work is the Faust. He has infulenced dramatically western civilization's works in music, drama, poetry and philosophy. ";
            philosophers.Add(cc);

            cc = new Philosopher
            {
                Name = "Morihei Ueshiba",
                DoB = 1883,
                DoP = 1969,
                Nationality = "Japan"
            };
            cc.ImageName = "Ueshiba.jpg"; 
            cc.Quote = "A true warrior is always armed with three things: the radiant sword of pacification; the mirror of bravery, wisdom, and friendship; and the precious jewel of enlightenment.";
            cc.Thesis = "Founder of Aikido. Ueshiba was one of the most distinguished pupils of Takeda Sokaku (the last real samurai) and received legendary Daito-ryu scrolls describing lethal combat techniques."+
                "Later he had a spiritual experience and removed all destructive techniques from his art.";
            philosophers.Add(cc);

            cc = new Philosopher
            {
                Name = "Edgar Cayce",
                DoB = 1877,
                DoP = 1945,
                Nationality = "USA"
            };
            cc.ImageName = "Cayce.jpg";
            cc.Quote = "Keep the mental in the attitude of contructive forces. See in every individual that which is hopeful, helpful. For that we think upon, we become.";
            cc.Thesis = "Philosopher, psychic, healer and prophet. The state of relaxation and meditation enabled Cayce to place his mind in contact with all time and space. From this state he could respond to diverse questions.";
            philosophers.Add(cc);

            cc = new Philosopher
            {
                Name = "Sokrates",
                DoB = 469,
                DoP = 399,
                Nationality = "Greece"
            };
            cc.ImageName = "Sokrates.jpg";
            cc.Quote = "Death may be the greatest of all human blessings.";
            cc.Thesis = "Perhaps his most important contribution to Western thought is his dialectic method of inquiry, "+
                "known as the Socratic Method or method of 'elenchos', which he largely applied to the examination of key moral concepts such as the Good and Justice. (Source:Wikipedia)";
            philosophers.Add(cc);

            cc = new Philosopher
            {
                Name = "Plato",
                DoB = 428,
                DoP = 438,
                Nationality = "Greece"
            };
            cc.ImageName = "Plato.jpg";
            cc.Quote = "All the gold which is under or upon the earth is not enough to give in exchange for virtue.";
            cc.Thesis = "Student of Socrates, wrote eloquent dialogues in which Socratesappears. Focused on value theory, nature of ideal state, problem of how reality can be knowable.";
            philosophers.Add(cc);

            cc = new Philosopher
            {
                Name = "Aristotle",
                DoB = 384,
                DoP = 322,
                Nationality = "Greece"
            };
            cc.ImageName = "Aristotle.jpg";
            cc.Quote = "All human actions have one or more of these seven causes: chance, nature, compulsion, habit, reason, passion, and desire.";
            cc.Thesis = "Student of Plato. Remarkable for contributions to many areas: logic, math, biology, metaphysics, ethics, political theory, aesthetics (drama), etc. Teacher of Alexander the Great.";
            philosophers.Add(cc);

            cc = new Philosopher
            {
                Name = "Pythagoras",
                DoB = 580,
                DoP = 490,
                Nationality = "Greece"
            };
            cc.ImageName = "Pythagoras.jpg";
            cc.Quote = "Above all things, reverence yourself.";
            cc.Thesis = "Born in Samos, Greece. Best known for the Pythagorean theorem, which bears his name. Known as 'the father of numbers'. Studied astrology and formulated music theory. Attented a Mystery School in Egypt.";
            philosophers.Add(cc);
                        
        }

        void CreateMenuItems()
        {
            // Philosophers MenuItem
            MenuItem controls_mi = new MenuItem();
            controls_mi.Header = "_Philosophers";
            
            // Create subitems
            foreach (Philosopher p in philosophers)
            {
                MenuItem mi = new MenuItem();
                mi.Header = p.Name;
                mi.IsCheckable = true;
                mi.Checked += new RoutedEventHandler(mi_Checked);
                controls_mi.Items.Add(mi);
            }
            
            // Add subitems to Menu
            menu1.Items.Add(controls_mi);
           

            // About MenuItem...
            MenuItem about_mi = new MenuItem();
            about_mi.Header = "_About";
            // ...and it's subitems
            MenuItem ab_mi = new MenuItem();
            ab_mi.Header = "About";
            ab_mi.Click += new RoutedEventHandler(about_mi_Click);
            about_mi.Items.Add(ab_mi);

            menu1.Items.Add(about_mi);
        }

        void about_mi_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Timo Toivonen 2009\n\nWPF is the next UI paradigm!");
        }
                
        void mi_Checked(object sender, RoutedEventArgs e)
        {
            string selectedItemHeader = ((MenuItem)e.Source).Header.ToString();

            // new C# 3.0 way to find an item's index from list
            int index = philosophers.FindIndex(p => p.Name == selectedItemHeader);
            list.SelectedIndex = index;
            ClearNotCurrentPhiloCheckmarksFromMenu(selectedItemHeader);
        }

        private void ClearNotCurrentPhiloCheckmarksFromMenu(string selectedItemHeader)
        {
            // clear all other checkmars but the current
            foreach (MenuItem m in ((MenuItem)menu1.Items[0]).Items)
                if (m.Header.ToString() != selectedItemHeader)
                    m.IsChecked = false;
        }

        private void CheckCurrentPhiloToMenu(string selectedItemHeader)
        {
            foreach (MenuItem m in ((MenuItem)menu1.Items[0]).Items)
                if (m.Header.ToString() == selectedItemHeader)
                    m.IsChecked = true;
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string currentItemHeader = (philoPresenter.DataContext as Philosopher).Name;
            // new C# 3.0 way to find an item's index from list
            int lindex = philosophers.FindIndex(p => p.Name == currentItemHeader);
            
            if (list.SelectedIndex > lindex)
                theDirection = CardChangeDirection.DOWN;
            else
                theDirection = CardChangeDirection.UP;

            StartOutAnimation();
        }

        // Not used, just for reference...old C# 2.0 Predicate to find item from list
        private bool IsCurrentPhilosopher(Philosopher p)
        {
            if (p.Name == (philoPresenter.DataContext as Philosopher).Name)
                return true;
            else
                return false;
        }

        void OutAnimation_Completed(object sender, EventArgs e)
        {
            StartInAnimation();
        }

        void StartOutAnimation()
        {
            this.philoPresenter.RenderTransformOrigin = new Point(1.0, 1.0);

            // Rotation animation
            DoubleAnimation rotateAnim = new DoubleAnimation();
            rotateAnim.From = AnimInFromAngle; // start degree
            rotateAnim.To = AnimInToAngle; // end degree
            rotateAnim.Duration = new Duration(TimeSpan.FromMilliseconds(rotationouttime));
            rotateAnim.Completed += new EventHandler(OutAnimation_Completed); // setting up the follow-up animation 

            RotateTransform rt = new RotateTransform(0, 0, 0);
            philoPresenter.RenderTransform = rt;

            // "Fade Out" -animation
            DoubleAnimation da = new DoubleAnimation();
            da.From = 1.0;
            da.To = 0.0;
            da.Duration = new Duration(TimeSpan.FromMilliseconds(fadeouttime));

            // Kick off both animations!
            rt.BeginAnimation(RotateTransform.AngleProperty, rotateAnim);
            this.philoPresenter.BeginAnimation(ComponentPresenterUserControl.OpacityProperty, da);
        }

        private void StartInAnimation()
        {
            this.philoPresenter.Margin = new Thickness(0, 0, 0, 0);
            this.philoPresenter.DataContext = philosophers[list.SelectedIndex];
            CheckCurrentPhiloToMenu(philosophers[list.SelectedIndex].Name);
            
            // Rotation animation
            DoubleAnimation rotateAnim = new DoubleAnimation();
            rotateAnim.From = AnimOutFromAngle; // starting degree
            rotateAnim.To = AnimOutToAngle; // ending degree
            rotateAnim.Duration = new Duration(TimeSpan.FromMilliseconds(rotationintime));
            RotateTransform rt = new RotateTransform(0, 0, 0);
            philoPresenter.RenderTransform = rt;

            // "Fade In" -animation
            DoubleAnimation da = new DoubleAnimation();
            da.From = 0.0;
            da.To = 1.0;
            da.Duration = new Duration(TimeSpan.FromMilliseconds(fadeintime));

            // Kick'em off!
            rt.BeginAnimation(RotateTransform.AngleProperty, rotateAnim);
            this.philoPresenter.BeginAnimation(ComponentPresenterUserControl.OpacityProperty, da);
        }
    }
}
