using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Habitual.Client {
    public class HabitsModel {

        public HabitsModel()
        {
            HabitConcepts = new List<HabitConcept>();
            HabitInstances = new List<HabitInstance>();
        }

        public List<HabitConcept> HabitConcepts { get; set; }

        public List<HabitInstance> HabitInstances { get; set; }

        private HabitConcept selectedConcept;
        public HabitConcept SelectedConcept { 
            get { return selectedConcept; }
            set {
                selectedConcept = value;
                MarkSelectedInstancesChanged();
            }
        }

        public List<HabitInstance> SelectedInstances { get{
            if(SelectedConcept != null) {
                return HabitInstances.Where(instance => instance.HabitId == selectedConcept.Id).ToList();
            }
            else {
                return new List<HabitInstance>();
            }
        } }

        public void AddConcept(HabitConcept concept){
            HabitConcepts.Add(concept);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HabitConcepts)));
        }

        public void UpdateConcept(HabitConcept concept){
            var conceptToUpdate = HabitConcepts.FirstOrDefault(item => item.Id == concept.Id);
            conceptToUpdate.UpdateFrom(concept);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HabitConcepts)));
        }

        public void AddInstance(HabitInstance instance){
            HabitInstances.Add(instance);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HabitInstances)));
            MarkSelectedInstancesChanged();
        }

        private void MarkSelectedInstancesChanged(){
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedInstances)));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}