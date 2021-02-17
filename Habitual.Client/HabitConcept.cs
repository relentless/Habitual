using System;

namespace Habitual.Client {
    public class HabitConcept {
        public string Name { get; set; }
        public HabitType Type { get; set; }
        public DateTime Start { get; set; }
        public bool Active { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + ", Type: " + Type;
        }
    }
}