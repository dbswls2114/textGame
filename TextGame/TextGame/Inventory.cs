using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public enum ItemType
    {
        Weapon,
        Armor
    }
    public class Item
    {
        public int id;
        public string name;
        public ItemType type;
        public string description;

    }
    public class Weapon : Item
    {
        public int atk;
        public Weapon(int _id, string _name, ItemType _type, int _atk, string _des)
        {
            id = _id;
            name = _name;
            type = _type;
            atk = _atk;
            description = _des;
        }
    }
    public class Armor : Item
    {
        public int def;
        public int hp;
        public Armor(int _id, string _name, ItemType _type, int _def, int _hp, string _des)
        {
            id = _id;
            name = _name;
            type = _type;
            def = _def;
            hp = _hp;
            description = _des;
        }
    }

    internal class Inventory
    {
        public List<Weapon> weapons = new List<Weapon>();
        public List<Armor> armors = new List<Armor>();
        Weapon w1 = new Weapon(1, "롱소드", ItemType.Weapon, 5, "평범한 롱소드");
        Weapon w2 = new Weapon(2,"목검", ItemType.Weapon, 1, "썩은 목검");
        Armor a1 = new Armor(3,"사슬갑옷", ItemType.Armor, 2, 10, "사슬로 만든 갑옷");
        Armor a2 = new Armor(4,"가죽옷", ItemType.Armor, 1, 5, "낡은 가죽옷");

        public Inventory()
        {
            weapons.Add(w1);
            weapons.Add(w2);
            armors.Add(a1);
            armors.Add(a2);
        }

        public void DisplayMyInventory()
        {
            Console.Clear();

            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("[무기]");
            foreach (Weapon item in weapons)
            {
                Console.WriteLine($"{item.name} / {item.type} / {item.atk} / {item.description}");
            }
            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("[방어구]");
            foreach(Armor item in armors)
            {
                Console.WriteLine($"{item.name} / {item.type} / {item.def} / {item.hp} / {item.description}");
            }
            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine("1. 장착관리");
        }
    }
}
