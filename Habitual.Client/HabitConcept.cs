using System;

namespace Habitual.Client {
    public class HabitConcept {

        public Guid Id {get; set;}
        public string Name { get; set; }
        public HabitType Type { get; set; }
        public DateTime Start { get; set; }
        public bool Active { get; set; }

        public HabitConcept()
        {
            Id = Guid.NewGuid();
            Start = DateTime.Now;
            Active = true;
            Type = HabitType.Good;
        }

        public static HabitConcept Create(){
            return new HabitConcept();
        }

        public override string ToString()
        {
            return "Id: " + Id + ", Name: " + Name + ", Type: " + Type;
        }

        public void UpdateFrom(HabitConcept conceptToCopy){
            this.Name = conceptToCopy.Name;
            this.Type = conceptToCopy.Type;
            this.Start = conceptToCopy.Start;
        }
    }
}