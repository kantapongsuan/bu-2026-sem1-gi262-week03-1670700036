using UnityEngine;


namespace Assignment.StudentSolution.LCT01
{
    public class Car
    {
        public string Name;
        public float Speed;
        public string Color;

        public void Move()
        {
            Debug.Log("Car is Moving");
        }
        public void Turn()
        {
            Debug.Log("Car is Turning");
        }
    }

    public class LCT01SyntaxClass
    {
        public void Start()
        {
            // Student code start HERE ...
            Car car1 = new Car();
            car1.Name = "Lamvogini";
            Debug.Log(car1.Name);
            car1.Move();
            car1.Turn();

            Car car2 = new();
            car2.Name = "Toyota";
            Debug.Log(car2.Name);
            // Student code ends HERE 
        }
    }
}
