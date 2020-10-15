using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLogicLib.Task6Logic;
using Task6.Properties;

namespace Task6
{
    public partial class Form2 : Form
    {
        private List<BookCloset2> BookClosetsList
        {
            get;
            set;
        }
        public Form2()
        {
            InitializeComponent();
            BookClosetsList = new List<BookCloset2>();
        }

        private void addToListButton_Click(object sender, EventArgs e)
        {
            try
            {
                int ownedAmount = Convert.ToInt32(ownedAmountTextBox.Text);
                double volume = Convert.ToDouble(volumeTextBox.Text);
                int shelvesAmount = Convert.ToInt32(shelvesAmountTextBox.Text);
                int amountOfBooks = Convert.ToInt32(amountOfBooksTextBox.Text);
                int maxAmountOfBooks = Convert.ToInt32(maxAmountOfBooksTextBox.Text);
                if (AreParamsValid(
                    ownedAmount, volume, shelvesAmount, amountOfBooks, maxAmountOfBooks))
                {
                    BookClosetsList.Add(new BookCloset2(
                        ownedAmount, volume, shelvesAmount, amountOfBooks, maxAmountOfBooks));
                    outputRichTextBox.Text = BookCloset2.GetTextInfoForList(BookClosetsList);
                }
            }
            catch (Exception)
            {
                // ignore
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            try 
            {
                int index = Convert.ToInt32(indexTextBox.Text);
                BookClosetsList[index].Buy();
                outputRichTextBox.Text = BookCloset2.GetTextInfoForList(BookClosetsList);
            }
            catch (Exception)
            {
                // ignore
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                int index = Convert.ToInt32(indexTextBox.Text);
                BookClosetsList[index].Sell();
                outputRichTextBox.Text = BookCloset2.GetTextInfoForList(BookClosetsList);
            }
            catch (Exception)
            {
                // ignore
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(indexTextBox.Text);
                BookClosetsList[index].AddBook();
                outputRichTextBox.Text = BookCloset2.GetTextInfoForList(BookClosetsList);
            }
            catch (Exception)
            {
                // ignore
            }
        }

        private void removeBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(indexTextBox.Text);
                BookClosetsList[index].RemoveBook();
                outputRichTextBox.Text = BookCloset2.GetTextInfoForList(BookClosetsList);
            }
            catch (Exception)
            {
                // ignore
            }
        }
        
        private bool AreParamsValid(
            int ownedAmount, double volume, 
            int shelvesAmount, int amountOfBooks, int maxAmountOfBooks)
        {
            return ownedAmount >= 0 &&
                   volume > 0 &&
                   shelvesAmount > 0 &&
                   amountOfBooks >= 0 &&
                   maxAmountOfBooks > 0 &&
                   maxAmountOfBooks >= amountOfBooks;
        }
    }
}