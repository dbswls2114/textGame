using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    internal class Shop
    {
        public List<Weapon> shopWeapons = new List<Weapon>();
        public List<Armor> shopArmors = new List<Armor>();
        Weapon w3 = new Weapon(5, "짱짱칼", ItemType.Weapon, 10, "짱짱칼이다.");
        Weapon w4 = new Weapon(6, "짱돌", ItemType.Weapon, 3, "짱돌. 매우아프다");
        Armor a3 = new Armor(7, "짱룡잠옷", ItemType.Armor, 3, 15, "짱룡잠옷이다. 귀엽다.");
        Armor a4 = new Armor(8, "투명옷", ItemType.Armor, 8, 100, "착한사람 눈에만 보인다.");
        public Shop()
        {
            shopWeapons.Add(w3);
            shopArmors.Add(a3);
            shopWeapons.Add(w4);
            shopArmors.Add(a4);
        }   

    }
}
