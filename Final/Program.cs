using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Prep()
        {
            Console.WriteLine("На Вашу кількість соток потрібно мл. препарату:");
        }

        static void Sotka()
        {
            Console.WriteLine("Введіть кількість соток для обробки. Якщо буде введено не вірну кількість соток – буде продемонстровано співвідношення для одієї сотки.");
        }

        static void Refusal()
        {
            Console.WriteLine("Упс! Задане число, або символ не відповідає жодному розділу.");
        }

        static int CostS(int a)
        {
            if (a > 0)
            {
                Console.WriteLine(10 * a);
            }
            else
            {
                a = 1;
                Console.WriteLine(a);
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
        Main_menu:
            Console.WriteLine("Добрий день! Оберіть число, яке відповідає розділу, який Вас цікавить: 1 - Стимулятори росту, 2 - Добрива, 3 - Біопрепарати.");
            int select_1 = Convert.ToInt32(Console.ReadLine());
            if (select_1 == 1)
            {
            SR_menu:
                Console.WriteLine("Ви обрали розділ Стимулятори росту. Натисніть 1, якщо потрібні Стимулятори росту для фруктів та овочів, або 2, якщо потрібні Стимулятори росту для квітів");
                int select_2 = Convert.ToInt32(Console.ReadLine());
                if (select_2 == 1)
                {
                SRF_menu:
                    Console.WriteLine("Ви обрали розділ Стимулятори росту для фруктів та овочів. В наявності є препарат Радіфарм - 1, або препарат Віва - 2. Зробіть свій вибір");
                    int select_2_2 = Convert.ToInt32(Console.ReadLine());
                    if (select_2_2 == 1)
                    {
                        Console.WriteLine("Ви обрали препарат Радіфарм. Радіфарм - біостимулятор розвитку кореневої системи. Це комплекс елементів, які стимулюють зростання коренів і підвищують рівень сприйнятливості. Він збалансований за складом та рекомендується до застосування для різних типів культур.");
                        Sotka();
                        int sotok = Convert.ToInt32(Console.ReadLine());
                        Prep();
                        int water = CostS(sotok) * 25;
                        Console.WriteLine("Розбавити у {0} літрах води ", water);
                    }
                    else if (select_2_2 == 2)
                    {
                        Console.WriteLine("Ви обрали препарат Віва. Препарат Віва – найпотужніший стимулятор зростання кореневої системи. Вноситься під корінь, тим самим створюючи необхідні умови для швидкого розвитку висаджених культур. Складається Віва з органічних сполук, комплексу вітамінів (В1, В6, РР), іностолу, фолієвої та гуамінової кислоти, амінокислот, полісахаридів, пептидів, протеїнів.");
                        Sotka();
                        int sotok = Convert.ToInt32(Console.ReadLine());
                        Prep();
                        int water = CostS(sotok) * 30;
                        Console.WriteLine("Розбавити у {0} літрах води ", water);
                    }
                    else
                    {
                        Refusal();
                        goto SRF_menu;
                    }
                }
                else if (select_2 == 2)
                {
                SRK_menu:
                    Console.WriteLine("Ви обрали розділ Стимулятори росту для квітів. В наявності є препарат Мегафол - 1, або препарат Кендал - 2. Зробіть свій вибір");
                    int select_2_2 = Convert.ToInt32(Console.ReadLine());
                    if (select_2_2 == 1)
                    {
                        Console.WriteLine("Ви обрали препарат Мегафол. Мегафол – біостимулятор росту та подолання стресових факторів у рослин (заморозки, посуха, висока температура).");
                        Sotka();
                        int sotok = Convert.ToInt32(Console.ReadLine());
                        Prep();
                        int water = CostS(sotok) * 25;
                        Console.WriteLine("Розбавити у {0} літрах води ", water);
                    }
                    else if (select_2_2 == 2)
                    {
                        Console.WriteLine("Ви обрали препарат Кендал. Кендал – біостимулятор посилення власних захисних реакцій рослин, зміцнює стінки клітин та підвищує стійкість до хвороб (фітофтороз, бактеріальна плямистість, фузаріоз та ін).");
                        Sotka();
                        int sotok = Convert.ToInt32(Console.ReadLine());
                        Prep();
                        int water = CostS(sotok) * 50;
                        Console.WriteLine("Розбавити у {0} літрах води ", water);
                    }
                    else
                    {
                        Refusal();
                        goto SRK_menu;
                    }
                }
                else
                {
                    Refusal();
                    goto SR_menu;
                }
            }
            else if (select_1 == 2)
            {
            Dob_menu:
                Console.WriteLine("Ви обрали розділ Добрива. Натисніть 1 - якщо потрібні Мінеральні добрива, 2 - якщо потрібні Органічні добрива, 3 - якщо потрібні Органо-мінеральні добрива, 4 - якщо потрібні Мікродобрива.");
                int select_3 = Convert.ToInt32(Console.ReadLine());
                if (select_3 == 1)
                {
                Dobm_menu:
                    Console.WriteLine("Ви обрали розділ Мінеральні добрива. В наявності є препарат Кеміра Люкс - 1, або Сірчанокислий марганець - 2. Зробіть свій вибір.");
                    int select_3_2 = Convert.ToInt32(Console.ReadLine());
                    if (select_3_2 == 1)
                    {
                        Console.WriteLine("Ви обрали препарат Кеміра Люкс. Кеміра Люкс - водорозчинне кореневе добриво для овочів, квітів та розсади.");
                        Sotka();
                        int sotok = Convert.ToInt32(Console.ReadLine());
                        Prep();
                        int water = CostS(sotok) * 20;
                        Console.WriteLine("Розбавити у {0} літрах води ", water);
                    }
                    else if (select_3_2 == 2)
                    {
                        Console.WriteLine("Ви обрали Сірчанокислий марганець. Сульфат марганцю – ефективне добриво для передпосівної обробки насіння та підживлення овочевих культур, плодових кущів та дерев.");
                        Sotka();
                        int sotok = Convert.ToInt32(Console.ReadLine());
                        Prep();
                        int water = CostS(sotok) * 15;
                        Console.WriteLine("Розбавити у {0} літрах води ", water);
                    }
                    else
                    {
                        Refusal();
                        goto Dobm_menu;
                    }
                }
                else if (select_3 == 2)
                {
                Dobo_menu:
                    Console.WriteLine("Ви обрали розділ Органічні добрива. В наявності є препарат Стимовіт - 1, або Агролайф - 2. Зробіть свій вибір.");
                     int select_3_2 = Convert.ToInt32(Console.ReadLine());
                     if (select_3_2 == 1)
                     {
                         Console.WriteLine("Ви обрали препарат Стимовіт. Стимовіт – високоефективне добриво, виготовлене з екстракту біогумусу. Збагачене макро- та мікроелементами та комплексом біологічно активних речовин природного походження. Стимовіт забезпечує потреби культур в органічних та мінеральних поживних речовинах. При застосуванні Стімовіту в ґрунт разом із гумусовими речовинами потрапляють вітаміни, ферменти, інші продукти життєдіяльності мікроорганізмів та каліфорнійського дощового хробака, що сприяють поліпшенню родючості ґрунту.");
                         Sotka();
                         int sotok = Convert.ToInt32(Console.ReadLine());
                         Prep();
                         int water = CostS(sotok) * 25;
                         Console.WriteLine("Розбавити у {0} літрах води ", water);
                     }
                     else if (select_3_2 == 2)
                     {
                         Console.WriteLine("Ви обрали препарат Агролайф. Агролайф – є якісним та незамінним засобом при вирощуванні овочів, плодово-ягідних, баштанних культур, декоративних рослин та квітів. Застосування добрива збільшує врожайність на 40-60%.");
                         Sotka();
                         int sotok = Convert.ToInt32(Console.ReadLine());
                         Prep();
                         int water = CostS(sotok) * 40;
                         Console.WriteLine("Розбавити у {0} літрах води ", water);
                     }
                     else
                     {
                         Refusal();
                         goto Dobo_menu;
                     }
                }
                else if (select_3 == 3)
                {
                Dobom_menu:
                    Console.WriteLine("Ви обрали розділ Органо-мінеральні добрива. В наявності є препарат Rost Концентрат - 1, або Хелп Рост - 2. Зробіть свій вибір.");
                    int select_3_2 = Convert.ToInt32(Console.ReadLine());
                    if (select_3_2 == 1)
                    {
                        Console.WriteLine("Ви обрали препарат Rost Концентрат. Rost Концентрат – органо-мінеральне добриво. Застосовується для позакореневого та кореневого підживлення овочів, плодово-ягідних культур, зернових, баштанних та квітів. Екологічно чистий препарат створений на основі гумату калію, що має у своєму складі в концентрованому вигляді мікро- та макроелементи, природні стимулятори, антибіотики, вітаміни, калій, азот, фосфор. Добриво стимулює зростання, покращує фотосинтез рослини, має фунгіцидні властивості. Сприятливо впливає на насіння при замочуванні у розчині препарату перед посадкою.");
                        Sotka();
                        int sotok = Convert.ToInt32(Console.ReadLine());
                        Prep();
                        int water = CostS(sotok) * 300;
                        Console.WriteLine("Розбавити у {0} літрах води ", water);
                    }
                    else if (select_3_2 == 2)
                    {
                        Console.WriteLine("Ви обрали препарат Хелп Рост. Хелп рост – рідке органно-мінеральне добриво з амінокислотами");
                        Sotka();
                        int sotok = Convert.ToInt32(Console.ReadLine());
                        Prep();
                        int water = CostS(sotok) * 250;
                        Console.WriteLine("Розбавити у {0} літрах води ", water);
                    }
                    else
                    {
                        Refusal();
                        goto Dobom_menu;
                    }
                }
                else if (select_3 == 4)
                {
                Dobmk_menu:
                    Console.WriteLine("Ви обрали розділ Мікродобрива. В наявності є препарат Цитовіт - 1, або Мікродобриво універсальне - 2. Зробіть свій вибір.");
                     int select_3_2 = Convert.ToInt32(Console.ReadLine());
                     if (select_3_2 == 1)
                     {
                         Console.WriteLine("Ви обрали препарат Цитовіт. Цитовіт містить повний комплекс макро- та мікроелементів у хелатній формі. Прискорює зростання рослин, підвищує їх стійкість до несприятливих умов вирощування (нестача світла при вирощуванні розсади, заморозки, підвищена вологість або, навпаки, посушлива погода), знижують опадання зав'язей, запобігають відмиранню точок росту, засіб для профілактики таких захворювань, як хлороз, фітофтороз, гнилі та ін.");
                         Sotka();
                         int sotok = Convert.ToInt32(Console.ReadLine());
                         Prep();
                         int water = CostS(sotok) * 2;
                         Console.WriteLine("Розбавити у {0} літрах води ", water);
                     }
                     else if (select_3_2 == 2)
                     {
                         Console.WriteLine("Ви обрали Мікродобриво універсальне. Мікродобриво універсальне (B, Cu, Mg, Mn, Fe, Zn) містить підібрані потрібні мікроелементи для успішного зростання, зняття стресових ситуацій, протистояння хвороби, підвищення врожайності, покращення якості, смаку, лежкості, транспортабельності плодів, покращення декоративних якостей рослин.");
                         Sotka();
                         int sotok = Convert.ToInt32(Console.ReadLine());
                         Prep();
                         int water = CostS(sotok) * 1;
                         Console.WriteLine("Розбавити у {0} літрах води ", water);
                     }
                     else
                     {
                         Refusal();
                         goto Dobmk_menu;
                     }
                }
                else
                {
                    Refusal();
                    goto Dob_menu;
                }
            }
            else if (select_1 == 3)
            {
            Bio_menu:
                Console.WriteLine("Ви обрали розділ Біопрепарати. В наявності є препарат Фітодоктор лист - 1 або препарат Триходермін - 2. Зробіть свій вибір");
                int select_3 = Convert.ToInt32(Console.ReadLine());
                if (select_3 == 1)
                {
                    Console.WriteLine("Ви обрали препарат Фітодоктор лист. Фітодоктор Лист - біологічний фунгіцид для профілактики та лікування рослин, ефективно запобігає прояву та діє антагоністично проти збудників широкого спектру хвороб рослин: Botrytis, Erwinia, Fusarium, Phytophthora, Pythium, Pyrenophora, Rhizoctonia,.");
                    Sotka();
                    int sotok = Convert.ToInt32(Console.ReadLine());
                    Prep();
                    int water = CostS(sotok) * 10;
                    Console.WriteLine("Розбавити у {0} літрах води ", water);
                }
                else if (select_3 == 2)
                {
                    Console.WriteLine("Ви обрали препарат Триходермін. Триходермін – біологічний фунгіцид на основі культури Trichoderma, ефективно пригнічує патогенні збудники, які поширюються через ґрунт та рослинні залишки.");
                    Sotka();
                    int sotok = Convert.ToInt32(Console.ReadLine());
                    Prep();
                    int water = CostS(sotok) * 20;
                    Console.WriteLine("Розбавити у {0} літрах води ", water);
                }
                else
                {
                    Refusal();
                    goto Bio_menu;
                }
            }
            else
            {
                Refusal();
                goto Main_menu;
            }
            Console.WriteLine("Бажаємо вдалого дня та гарного врожаю!");
            Console.ReadKey();
        }
    }
}