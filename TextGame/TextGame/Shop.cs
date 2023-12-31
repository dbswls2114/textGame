﻿using System;
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
        Weapon w3 = new Weapon(5, "짱짱칼", ItemType.Weapon, 10, "짱짱칼이다.", 500);
        Weapon w4 = new Weapon(6, "짱돌", ItemType.Weapon, 3, "짱돌. 매우아프다", 300);
        Armor a3 = new Armor(7, "짱룡잠옷", ItemType.Armor, 3, 15, "짱룡잠옷이다. 귀엽다.", 500);
        Armor a4 = new Armor(8, "투명옷", ItemType.Armor, 8, 100, "착한사람 눈에만 보인다.",1000);
        
        public Shop()
        {
            shopWeapons.Add(w3);
            shopArmors.Add(a3);
            shopWeapons.Add(w4);
            shopArmors.Add(a4);
        }

        public void DisplayShop()
        {
            int itemNum = 1;
            Console.Clear();

            Console.WriteLine("상점!");
            Console.WriteLine("아이템을 구매할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("[무기]");
            foreach (Weapon item in shopWeapons)
            {
                Console.WriteLine($"{itemNum}. {item.name} / {item.type} / {item.atk} / {item.description} / 가격 : {item.price} G");
                itemNum++;
            }
            itemNum = 1;
            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("[방어구]");
            foreach (Armor item in shopArmors)
            {
                Console.WriteLine($"{itemNum}. {item.name} / {item.type} / {item.def} / {item.hp} / {item.description} / 가격 : {item.price} G");
                itemNum++;
            }
            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine("1. 무기 구매");
            Console.WriteLine("2. 방어구 구매");
            
        }
    }
}
