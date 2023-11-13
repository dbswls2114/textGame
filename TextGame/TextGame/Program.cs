using System.Numerics;

namespace TextGame
{
    internal class Program
    {
        private static Character player;
        private static Inventory inventory = new Inventory();

        static void Main()
        {
            GameDataSetting();
            player.weapon = inventory.weapons[0];
            player.armor = inventory.armors[0];           
            DisplayGameIntro();
        }

        static void GameDataSetting()
        {
            // 캐릭터 정보 세팅
            player = new Character("Chad", "전사", 1, 10, 5, 100, 1500);

            // 아이템 정보 세팅
        }

        static void DisplayGameIntro()
        {
            Console.Clear();

            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 전전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");

            int input = CheckValidInput(1, 2);
            switch (input)
            {
                case 1:
                    DisplayMyInfo();
                    break;

                case 2:
                    DisplayInventory();
                    break;
            }
        }

        static void DisplayMyInfo()
        {
            Console.Clear();

            Console.WriteLine("상태보기");
            Console.WriteLine("캐릭터의 정보를 표시합니다.");
            Console.WriteLine();
            Console.WriteLine($"Lv.{player.Level}");
            Console.WriteLine($"{player.Name}({player.Job})");
            Console.WriteLine($"공격력 :{player.Atk} ({player.weapon.atk})");
            Console.WriteLine($"방어력 : {player.Def} ({player.armor.def})");
            Console.WriteLine($"체력 : {player.Hp} ({player.armor.hp})");
            Console.WriteLine($"Gold : {player.Gold} G");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");

            int input = CheckValidInput(0,0);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
            }
        }

        static void DisplayInventory()
        {
            inventory.DisplayMyInventory();

            int input = CheckValidInput(0, 1);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
                case 1:
                    DisplaySetItem();                    
                    break;
            }
        }
        static void DisplaySetItem()
        {
            int itemNum = 1;
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("[무기]");
            foreach (Weapon item in inventory.weapons)
            {
                if(player.weapon == item)
                {
                    Console.Write("[E]");
                }
                Console.WriteLine($"{itemNum}. {item.name} / {item.type} / {item.atk} / {item.description}");
                itemNum++;
            }
            itemNum = 1;
            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("[방어구]");
            foreach (Armor item in inventory.armors)
            {
                
                if (player.armor == item)
                {
                    Console.Write("[E]");
                }
                Console.WriteLine($"{itemNum}. {item.name} / {item.type} / {item.def} / {item.hp} / {item.description}");
                itemNum++;
            }
            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("0. 나가기");
            Console.WriteLine("1. 무기장착");
            Console.WriteLine("2. 방어구장착");

            int input = CheckValidInput(0, 2);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
                case 1:
                    Console.WriteLine("장착할 무기의 번호를 입력하세요");
                    int winput = CheckValidInput(1, inventory.weapons.Count);
                    player.weapon = inventory.weapons[winput-1];
                    Console.WriteLine("장착완료");
                    DisplayInventory();
                    break;
                case 2:
                    Console.WriteLine("장착할 방어구의 번호를 입력하세요");
                    int ainput = CheckValidInput(1, inventory.armors.Count);
                    player.armor = inventory.armors[ainput-1];
                    Console.WriteLine("장착완료");
                    DisplayInventory();
                    break;
            }
        }

        static int CheckValidInput(int min, int max)
        {
            while (true)
            {
                string input = Console.ReadLine();

                bool parseSuccess = int.TryParse(input, out var ret);
                if (parseSuccess)
                {
                    if (ret >= min && ret <= max)
                        return ret;
                }

                Console.WriteLine("잘못된 입력입니다.");
            }
        }
    }

    public class Character
    {
        public string Name { get; }
        public string Job { get; }
        public int Level { get; }
        public int Atk { get; }
        public int Def { get; }
        public int Hp { get; }
        public int Gold { get; }
        public Weapon weapon;
        public Armor armor;

        public Character(string name, string job, int level, int atk, int def, int hp, int gold)
        {
            Name = name;
            Job = job;
            Level = level;
            Atk = atk;
            Def = def;
            Hp = hp;
            Gold = gold;
        }
    }
}