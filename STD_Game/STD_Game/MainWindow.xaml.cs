using System;
using System.Collections.Generic;
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
using System.Windows.Threading;

namespace STD_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*initiates a timer to be used by GameEngine*/
        DispatcherTimer gameTimer = new DispatcherTimer();

        /*int used by GameEngine to calculate the balloons speed*/
        int speed = 3;
        /*int used by GameEngine to determine when a new balloon is to be spawned*/
        int intervals = 90;
        /*used to get random values*/
        Random rand = new Random();

        /*a rectangle type list named itemRemover*/
        List<Rectangle> itemRemover = new List<Rectangle>();
        /*initiates the background image for the game*/
        ImageBrush backgroundImage = new ImageBrush();

        /*int used by GameEngine to determine what skin/texture the balloon will have*/
        int balloonSkins;
        /*beautiful int named i*/
        int i;

        /*initiates the int that keeps track of how many balloons have been missed*/
        int missedBalloons;

        /*true or false boolean initiated*/
        bool gameIsActive;

        /*initiates int that keeps track of score*/
        int score;

        /*initiates a mediaplayer in order to move images and textures*/
        MediaPlayer player = new MediaPlayer();
        public MainWindow()
        {
            /*initializes component*/
            InitializeComponent();

            /*every 20 milliseconds the GameEngine eventhandler is run*/
            gameTimer.Tick += GameEngine;
            /*the interval that gameTimer.Tick uses when deciding when to run*/
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);

            /*the source for the background image*/
            backgroundImage.ImageSource = new BitmapImage(new Uri("C:\\Users\\hugo.pollack\\Documents\\GitHub\\STD\\STD_Game\\STD_Game\\MyResources\\Background2 - kopia.png"));
            /*sets the canvas background to our background image*/
            MyCanvas.Background = backgroundImage;

            /*when gameTimer.Tick stops running the GameEngine this method is run*/
            RestartGame();
        }

        /*is run every 20 milliseconds by the gameTimer.Tick function.
         GameEngine keeps track on the score, creates new balloons and moves those balloons*/
        private void GameEngine(object sender, EventArgs e)
        {
            /*gives scoreText a dynamic score value to display*/
            scoreText.Content = "Score: " + score;

            /*we dont want to spawn a balloon every 20 milliseconds, the tick time, 
             *so intervals is decreased by 10 every tick*/
            intervals -= 10;

            /*when intervals is under 1 a new balloon is spawned*/
            if (intervals < 1)
            {
                /*creates a new balloon image*/
                ImageBrush balloonImage = new ImageBrush();

                /*balloonSkins cycles through 1 to 5*/
                balloonSkins += 1;

                /*when balloonSkins is over five it is set to one again and the cycle continues*/
                if (balloonSkins > 5)
                {
                    balloonSkins = 1;
                }

                /*takes the value determined in tha balloonSkins if statements 
                 * and uses it to get a random image file for the balloon*/
                switch (balloonSkins)
                {
                    case 1:
                        balloonImage.ImageSource = new BitmapImage(new Uri("C:\\Users\\hugo.pollack\\Documents\\GitHub\\STD\\STD_Game\\STD_Game\\MyResources\\Hugo - kopia.png"));
                    break;
                    case 2:
                        balloonImage.ImageSource = new BitmapImage(new Uri("C:\\Users\\hugo.pollack\\Documents\\GitHub\\STD\\STD_Game\\STD_Game\\MyResources\\Praxel - kopia.png"));
                    break;
                    case 3:
                        balloonImage.ImageSource = new BitmapImage(new Uri("C:\\Users\\hugo.pollack\\Documents\\GitHub\\STD\\STD_Game\\STD_Game\\MyResources\\SimonSad - kopia.png"));
                    break;
                    case 4:
                        balloonImage.ImageSource = new BitmapImage(new Uri("C:\\Users\\hugo.pollack\\Documents\\GitHub\\STD\\STD_Game\\STD_Game\\MyResources\\TomasHappy - kopia.png"));
                    break;
                    case 5:
                        balloonImage.ImageSource = new BitmapImage(new Uri("C:\\Users\\hugo.pollack\\Documents\\GitHub\\STD\\STD_Game\\STD_Game\\MyResources\\TomasHappy - kopia.png"));
                    break;
                }

                /*makes a new balloon with a tag, dimensions 
                 * and uses the balloon image determined above for the texture*/
                Rectangle newBalloon = new Rectangle
                {
                    Tag = "Balloon",
                    Height = 500,
                    Width = 500,
                    Fill = balloonImage
                };

                /*gives the newBalloon positions at a random x coordinate between 50 and 400 
                 *and at 600 pixels from the top; at the bottom*/
                Canvas.SetLeft(newBalloon, rand.Next(50, 400));
                Canvas.SetTop(newBalloon, 600);

                /*adds the newBalloon to the canvas at the position it was given*/
                MyCanvas.Children.Add(newBalloon);

                /*makes intervals random in order to make balloon spawning more random*/
                intervals = rand.Next(90, 150);
            }

            /*a foreach loop that searches for all rectangle type objekts that are on the canvas*/
            foreach (var x in MyCanvas.Children.OfType<Rectangle>())
            {
                /*runs if the rectangle that was found on MyCanvas has a "balloon" string as a tag*/
                if ((string)x.Tag == "balloon")
                {
                    /*sets i to a random value between -5 and 5*/
                    i = rand.Next(-5, 5);

                    /*the position is changed so that the balloon's distance from the top of the 
                     *canvas is decreased by speed once every tick.
                     this makes the balloons move up*/
                    Canvas.SetTop(x, Canvas.GetTop(x) - speed);
                    /*changes the position of the balloon on the x axis*/
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - (i * -1));
                }
            }
        }

        private void Pop(object sender, MouseButtonEventArgs e)
        {

        }

        private void StartGame()
        {
            /*starts the gameTimer which in turn runs GameEngine*/
            gameTimer.Start();

            missedBalloons = 0;
            score = 0;
            intervals = 90;
            gameIsActive = true;
            speed = 3;
        }

        private void RestartGame()
        {
            /*adds every rectangle object type on the canvas to the remover list*/
            foreach (var x in MyCanvas.Children.OfType<Rectangle>())
            {
                itemRemover.Add(x);
            }

            /*removes everything in the itemRemover list*/
            foreach (Rectangle y in itemRemover)
            {
                MyCanvas.Children.Remove(y);
            }

            /*clears the itemRemover list*/
            itemRemover.Clear();

            /*starts the game*/
            StartGame();
        }
    }
}
