﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DataBinding {
    /// <summary>
    /// Interaction logic for BindingToCollection.xaml
    /// </summary>
    public partial class BindingToCollection : Window {
        public ObservableCollection<Craftsman> Craftsmen { get; private set; }

        public BindingToCollection() {
            Craftsmen = new ObservableCollection<Craftsman>() {
                new Craftsman() {Age = 45, LastName = "Jack", Name = "Mark", PicturePath = "Images/Jack.jpeg"},
                new Craftsman() {Age = 60, LastName = "Bob", Name = "Robert", PicturePath = "Images/Bob.jpg"},
            };

            InitializeComponent();
        }

        private void AddCraftsman_OnClick(object sender, RoutedEventArgs e) {
            Task.Run(() => {
                Craftsmen.Add(new Craftsman() {
                    Age = 60,
                    LastName = "Nick",
                    Name = "Martin",
                    PicturePath = "Images/John.jpg"
                });
            });
        }
    }
}