using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    public partial class NotesWindow: Window
    {
        private List<string> notes;

        public NotesWindow()
        {
            InitializeComponent();
            notes = new List<string>();
        }

        public void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string note = NotesTextBox.Text;
            if (!string.IsNullOrWhiteSpace(note))
            {
                notes.Add(note);
                NotesListBox.Items.Add(note);
                NotesTextBox.Clear();
                MessageBox.Show("Заметка добавлена!");
            }
            else
            { MessageBox.Show("Введите текст заметки."); }
        }

        public void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (NotesListBox.SelectedItem != null)
            {
                string selectedNote = NotesListBox.SelectedItem.ToString();
                notes.Remove(selectedNote);
                NotesListBox.Items.Remove(selectedNote);
                MessageBox.Show("Заметка удалена!");
            }
            else
            { MessageBox.Show("Выберите заметку для удаления.");}
        }
    }
}
