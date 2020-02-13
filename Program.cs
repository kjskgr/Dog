using System;

namespace Doggy
{
    public enum Gender{
            Male,Female
        }
    class Dog{
        private string name;
        private string owner;
        private int age;
        private string length;
        private string pronoun, pronoun2, sentence;
        public Gender gender;
        public Dog(string name, string owner, int age, Gender gender){
         this.name=name;
         this.owner=owner;
         this.age=age;
         this.gender=gender;
        }
        public void Bark(int barks){
            for(int i=0;i<barks;i++){
                Console.WriteLine("Woof!");
            }
        }
        public string GetTag(){
            if (age<=1){
                length="year";
            }
            else{
                length="years";
            }
            if (gender==0){
                pronoun = "His";
                pronoun2 = "he";
            }
            else{
                pronoun = "Her";
                pronoun2 = "she";
            }
            sentence = "If lost, call "+owner+". "+pronoun+" name is "+name+" and "+pronoun2+" is "+age+" "+length+" old";
            return sentence;
        }
    }    
    
    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion","Shawn", 1, Gender.Male);
            puppy.Bark(3);
            Console.WriteLine(puppy.GetTag());

            Dog myDog = new Dog("Lileu","Dale",4,Gender.Female);
            myDog.Bark(1);
            Console.WriteLine(myDog.GetTag());
        }

    }
}
