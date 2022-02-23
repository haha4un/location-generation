using System.Windows;
using System.Windows.Controls;

namespace location_generation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // haha4un is maker (⊙_⊙;)


        const int questNum = 1;
        public MainWindow()
        {
            InitializeComponent();
            /*
             * короче, задача такова: есть у комбо бокса, visibli. Делаем 
             * несколько комбобоксов и накладываем их друг на друга. Кнопками
             * переключаемся, а слева вверху будут показано что выбрали. Сидел 40 минут думал,
             * как красиво сделать. Потом подключем нейронку(наверное)
             */

            TegerChange();
        }
        uint questCount = 0;

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (questCount == 0)
                questCount = 0;
            else
                questCount--;


            WhatQuest(questNum: questCount);
            test.Text = "back";
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (questCount > questNum)
                questCount = questNum;
            else
                questCount++;


            WhatQuest(questNum: questCount);
            test.Text = "next";
        }

        private void location_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Location()
        {

        }

        private uint WhatQuest(uint questNum = 0)
        {
            switch (questNum)
            {
                case 0:
                    TegerChange(0);
                    return 0;
                    break;
                case 1:
                    TegerChange(1);
                    return 1;
                    break;
                default:
                    TegerChange();
                    return 0;
                    break;
            }

            return questNum;
        }

        private void TegerChange(uint questNum = 0)
        {
            switch (questNum)
            {
                case 0:
                    teger.Text = "Choose location";

                    questsCount1n2.Text = "1/2";

                    location.Visibility = Visibility.Visible;
                    setting.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    teger.Text = "Choose setting";

                    questsCount1n2.Text = "2/2";

                    setting.Visibility = Visibility.Visible;
                    location.Visibility = Visibility.Hidden;
                    break;
            }
        }
    }
}
