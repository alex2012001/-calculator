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
using System.Windows.Shapes;

namespace calculator
{
    /// <summary>
    /// Логика взаимодействия для if2.xaml
    /// </summary>
    public partial class if2 : Window
    {
        public if2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();


            int AteamCountForStop = 10;
            Random rand = new Random();
            int teamARandomKol = 0;
            int teamBRandomKol = 0;
            int globalWinsA = 0;
            int globalWinsB = 0;
            int waves = 3;
            int countBattle = 100;
            //В переменной count данные о количестве игроков
            int countTeamA = main.count;
            int[] hpA = new int[main.count];
            int[] forceA = new int[main.count];
            int[] protectA = new int[main.count];

            //Вместо цикла ввод с текстбоксов 
            hpA[0] = Convert.ToInt32(P1H.Text);
            forceA[0] = Convert.ToInt32(P1A.Text);
            protectA[0] = Convert.ToInt32(P1P.Text);

            hpA[1] = Convert.ToInt32(P2H.Text);
            forceA[1] = Convert.ToInt32(P2A.Text);
            protectA[1] = Convert.ToInt32(P2P.Text); 


            int countTeamB = 6;
            int[] hpB = new int[countTeamB];
            int[] forceB = new int[countTeamB];
            int[] protectB = new int[countTeamB];
            EnemyStats(ref hpB, ref forceB, ref protectB);
            while (AteamCountForStop > 0)
            {
                //ЗДЕСЬ ВЫВОД КОМАНДЫ ИГРОКОВ
                while (globalWinsB <= 30)
                {
                    //ЗДЕСЬ ВЫВОД КОМАНДЫ ПРОТИВНИКОВ
                    while (countBattle > 0) //ЦИКЛ ДЛЯ ЗАДАННОГО КОЛИЧЕСТВА БОЕВ
                    {
                        int[] hpBinBattle = new int[countTeamB];
                        int[] forceBinBattle = new int[countTeamB];
                        int[] protectBinBattle = new int[countTeamB];
                        int[] hpAinBattle = new int[countTeamA];
                        int[] forceAinBattle = new int[countTeamA];
                        int[] protectAinBattle = new int[countTeamA];
                        for (int i = 0; i < countTeamB; i++)
                        {
                            hpBinBattle[i] = hpB[i];
                            forceBinBattle[i] = forceB[i];
                            protectBinBattle[i] = protectB[i];
                        }
                        for (int i = 0; i < countTeamA; i++)
                        {
                            hpAinBattle[i] = hpA[i];
                            forceAinBattle[i] = forceAinBattle[i];
                            protectAinBattle[i] = protectA[i];
                        }
                        int countWaves = waves;
                        while (countWaves > 0)
                        {
                            int countAttackA = 0;
                            int countAttackB = 0;
                            //АТАКА КОМАНДЫ ИГРОКОВ
                            for (int i = 0; i < countTeamB; i++)
                            {
                                for (int j = countAttackA; j < countTeamA; j++)
                                {
                                    if (hpBinBattle[i] > 0 && hpAinBattle[j] > 0)
                                    {
                                        int r = rand.Next(1, 7);
                                        if (forceAinBattle[j] + r > protectBinBattle[i])
                                        {
                                            hpBinBattle[i]--;
                                        }
                                        if (hpBinBattle[i] == 0)
                                        {
                                            countAttackA = j + 1;
                                            break;
                                        }
                                        countAttackA = j + 1;
                                    }
                                }
                            }
                            int winA = 0;
                            for (int i = 0; i < countTeamB; i++)
                            {
                                if (hpBinBattle[i] <= 0)
                                {
                                    winA++;
                                }
                            }
                            if (winA == countTeamB)
                            {
                                countWaves--;
                                if (countWaves == 0)
                                {
                                    globalWinsA++;
                                }
                            }
                            // АТАКА КОМАНДЫ МОНСТРОВ
                            for (int i = 0; i < countTeamA; i++)
                            {
                                for (int j = countAttackB; j < countTeamB; j++)
                                {
                                    if (hpAinBattle[i] > 0 && hpBinBattle[j] > 0)
                                    {
                                        int r = rand.Next(1, 7);
                                        if (forceBinBattle[j] + r > protectAinBattle[i])
                                        {
                                            hpAinBattle[i]--;
                                        }
                                        if (hpAinBattle[i] == 0)
                                        {
                                            countAttackB = j + 1;
                                            break;
                                        }
                                        countAttackB = j + 1;
                                    }
                                }
                            }
                            int winB = 0;
                            for (int i = 0; i < countTeamA; i++)
                            {
                                if (hpAinBattle[i] <= 0)
                                {
                                    winB++;
                                }
                            }
                            if (winB == countTeamA)
                            {
                                globalWinsB++;
                                break;
                            }
                        }
                        countBattle--;
                    }
                    //ЗДЕСЬ ПРОЦЕНТ ПОБЕД который храниться в переменно glovalWinsA
                    TeamBRandom(ref teamBRandomKol, ref hpB, ref forceB, ref protectB);
                }
                TeamARandom(ref teamARandomKol, ref hpA, ref forceA, ref protectA);
                AteamCountForStop--;
            }
        }

        public static void TeamBRandom(ref int teamBRandomKol, ref int[] hpB, ref int[] forceB, ref int[] protectB)
        {
            int m = 6;
            int[] mas = new int[m];
            mas[0] = 0;
            mas[1] = 1;
            mas[2] = 2;
            mas[3] = 3;
            mas[4] = 4;
            mas[5] = 5;
            while (true)
            {
                int count = 0;
                if (mas[5] < 7)
                {
                    mas[5]++;
                }
                else
                {
                    mas[5] = 1;
                    if (mas[4] < 7)
                    {
                        mas[4]++;
                    }
                    else
                    {
                        mas[4] = 1;
                        if (mas[3] < 7)
                        {
                            mas[3]++;
                        }
                        else
                        {
                            mas[3] = 1;
                            if (mas[2] < 7)
                            {
                                mas[2]++;
                            }
                            else
                            {
                                mas[2] = 1;
                                if (mas[1] < 7)
                                {
                                    mas[1]++;
                                }
                                else
                                {
                                    mas[1] = 1;
                                    if (mas[0] < 7)
                                    {
                                        mas[0]++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                            }
                        }
                    }
                }
                if (mas[0] != mas[1] && mas[0] != mas[2] && mas[0] != mas[3] && mas[0] != mas[4] && mas[0] != mas[5] && mas[1] != mas[2] && mas[1] != mas[3] && mas[1] != mas[4] && mas[1] != mas[5] && mas[2] != mas[3] && mas[2] != mas[4] && mas[2] != mas[5] && mas[3] != mas[4] && mas[3] != mas[5] && mas[4] != mas[5] && mas[0] != 7 && mas[1] != 7 && mas[2] != 7 && mas[3] != 7 && mas[4] != 7 && mas[5] != 7 && count < teamBRandomKol)
                {
                    for (int i = 0; i < mas.Length; i++)
                    {
                        switch (mas[i])
                        {
                            case 0: hpB[i] = 1; forceB[i] = 1; protectB[i] = 2; break;
                            case 1: hpB[i] = 1; forceB[i] = 1; protectB[i] = 2; break;
                            case 2: hpB[i] = 2; forceB[i] = 2; protectB[i] = 2; break;
                            case 3: hpB[i] = 2; forceB[i] = 2; protectB[i] = 2; break;
                            case 4: hpB[i] = 3; forceB[i] = 3; protectB[i] = 3; break;
                            case 5: hpB[i] = 3; forceB[i] = 3; protectB[i] = 3; break;
                        }

                    }
                    teamBRandomKol++;
                }
            }
        }




        public static void TeamARandom(ref int teamARandomKol, ref int[] hpA, ref int[] forceA, ref int[] protectA)
        {
            int m = 4;
            int[] mas = new int[m];
            mas[0] = 0;
            mas[1] = 1;
            mas[2] = 2;
            mas[3] = 3;
            while (true)
            {
                int count = 0;

                if (mas[3] < 7)
                {
                    mas[3]++;
                }
                else
                {
                    mas[3] = 1;
                    if (mas[2] < 7)
                    {
                        mas[2]++;
                    }
                    else
                    {
                        mas[2] = 1;
                        if (mas[1] < 7)
                        {
                            mas[1]++;
                        }
                        else
                        {
                            mas[1] = 1;
                            if (mas[0] < 7)
                            {
                                mas[0]++;
                            }
                            else
                            {
                                break;
                            }
                        }

                    }
                }
                if (mas[0] != mas[1] && mas[0] != mas[2] && mas[0] != mas[3] && mas[1] != mas[2] && mas[1] != mas[3] && mas[2] != mas[3] && mas[0] != 4 && mas[1] != 4 && mas[2] != 4 && mas[3] != 4 && count < teamARandomKol)
                {
                    for (int i = 0; i < mas.Length; i++)
                    {
                        switch (mas[i])
                        {
                            case 0: hpA[i] = 2; forceA[i] = 0; protectA[i] = 2; break;
                            case 1: hpA[i] = 3; forceA[i] = 1; protectA[i] = 3; break;
                            case 2: hpA[i] = 5; forceA[i] = 1; protectA[i] = 1; break;
                            case 3: hpA[i] = 3; forceA[i] = 2; protectA[i] = 2; break;
                        }
                    }
                    teamARandomKol++;
                }
            }
        }

        public static void EnemyStats(ref int[] hpB, ref int[] forceB, ref int[] protectB)
        {
            hpB[0] = 1;
            hpB[1] = 1;
            hpB[2] = 2;
            hpB[3] = 2;
            hpB[4] = 3;
            hpB[5] = 3;
            forceB[0] = 1;
            forceB[1] = 1;
            forceB[2] = 2;
            forceB[3] = 2;
            forceB[4] = 3;
            forceB[5] = 3;
            protectB[0] = 2;
            protectB[1] = 2;
            protectB[2] = 2;
            protectB[3] = 2;
            protectB[4] = 3;
            protectB[5] = 3;
        }

    }
}
