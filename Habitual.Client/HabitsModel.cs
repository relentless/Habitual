using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Habitual.Client {
    public class HabitsModel {

        public HabitsModel()
        {
            HabitConcepts = new List<HabitConcept>();
        }

        public List<HabitConcept> HabitConcepts { 
            get; set;
        }

        public void AddConcept(HabitConcept concept){
            HabitConcepts.Add(concept);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HabitConcepts)));
        }

        public void UpdateConcept(HabitConcept concept){
            var conceptToUpdate = HabitConcepts.FirstOrDefault(item => item.Id == concept.Id);
            conceptToUpdate.UpdateFrom(concept);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HabitConcepts)));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}