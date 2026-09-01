using System.Globalization;
using UnityEngine;

namespace Assignment.StudentSolution.LCT03
{
    public class Animal
    {
        public string name;

        public void MakeSound()
        {
            Debug.Log($"Animal {name} is making sound");
        }
    }

    // class Dog inherits from Animal
    public class Dog : Animal
    {
        public void Walk()
        {
            Debug.Log($"{name} is walking");
        }
    }

    // class Bird inherits from Animal
    public class Bird : Animal
    {
        public void Walk()
        {
            Debug.Log($"{name} is walking");
        }
        public void Fly()
        {
            Debug.Log($"{name} is Flying");
        }
    }

    public class LCT03Inheritance
    {

        public void Start()
        {
            // 1. สร้าง instance ของ class Dog โดยกำหนดชื่อตัวแปรว่า dog
            // + กำหนดชื่อ (name) ว่า "Buddy"
            // + เรียกใช้ method MakeSound() ของ dog
            // + เรียกใช้ method Walk() ของ dog
            Dog dog = new Dog();
            dog.name = "Buddy";
            dog.MakeSound();


            // 2. สร้าง instance ของ class Bird โดยกำหนดชื่อตัวแปรว่า bird
            // + กำหนดชื่อ (name) ว่า "Twitty"
            // + เรียกใช้ method MakeSound() ของ bird
            // + เรียกใช้ method Fly() ของ bird
            Bird bird = new();
            bird.name = "Twitty";
            bird.MakeSound();

        }
    }
}
