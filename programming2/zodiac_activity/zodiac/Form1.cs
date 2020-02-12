using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using zodiac;

namespace zodiac
{
    public partial class zodiacForm : Form
    {

        // Globals
        string fullName, horoscope, chineseZodiac;
        int birthMonth, birthDate, birthYear, monthValue;
        byte[] chineseZodiacImageLoad, horoscopeImageLoad;
        string fieldEmptyErr = "* Required field";

        // Catch special characters and numbers
        Regex alpha = new Regex("^[a-zA-Z ^. \f\n\r\t\v]*$");

        // Load Images chinese zodiac
        System.IO.DirectoryInfo monkey = new System.IO.DirectoryInfo("images\\monkey.png");
        System.IO.DirectoryInfo rooster = new System.IO.DirectoryInfo("images\\rooster.png");
        System.IO.DirectoryInfo dog = new System.IO.DirectoryInfo("images\\dog.png");
        System.IO.DirectoryInfo pig = new System.IO.DirectoryInfo("images\\pig.png");
        System.IO.DirectoryInfo rat = new System.IO.DirectoryInfo("images\\rat.png");
        System.IO.DirectoryInfo ox  = new System.IO.DirectoryInfo("images\\ox.png");
        System.IO.DirectoryInfo tiger = new System.IO.DirectoryInfo("images\\tiger.png");
        System.IO.DirectoryInfo rabbit = new System.IO.DirectoryInfo("images\\rabbit.png");
        System.IO.DirectoryInfo dragon = new System.IO.DirectoryInfo("images\\dragon.png");
        System.IO.DirectoryInfo snake = new System.IO.DirectoryInfo("images\\snake.png");
        System.IO.DirectoryInfo horse = new System.IO.DirectoryInfo("images\\horse.png");
        System.IO.DirectoryInfo goat = new System.IO.DirectoryInfo("images\\goat.png");


        // Load Images horoscope
        System.IO.DirectoryInfo aries = new System.IO.DirectoryInfo("images\\aries.png");
        System.IO.DirectoryInfo taurus= new System.IO.DirectoryInfo("images\\taurus.png");
        System.IO.DirectoryInfo gemini = new System.IO.DirectoryInfo("images\\gemini.png");
        System.IO.DirectoryInfo cancer = new System.IO.DirectoryInfo("images\\cancer.png");
        System.IO.DirectoryInfo leo = new System.IO.DirectoryInfo("images\\leo.png");
        System.IO.DirectoryInfo virgo = new System.IO.DirectoryInfo("images\\virgo.png");
        System.IO.DirectoryInfo libra = new System.IO.DirectoryInfo("images\\libra.png");
        System.IO.DirectoryInfo scorpio = new System.IO.DirectoryInfo("images\\scorpio.png");
        System.IO.DirectoryInfo sagittarius = new System.IO.DirectoryInfo("images\\sagittarius.png");
        System.IO.DirectoryInfo capricorn = new System.IO.DirectoryInfo("images\\capricorn.png");
        System.IO.DirectoryInfo aquarius = new System.IO.DirectoryInfo("images\\aquarius.png");
        System.IO.DirectoryInfo pisces = new System.IO.DirectoryInfo("images\\pisces.png");

        private void getChineseZodiac()
        {
            // Switch values for chinese zodiac
            monthValue = birthYear % 12;

            switch (monthValue)
            {
                case 0:
                    chineseZodiac = "Monkey";
                    Image monkeyImg = Image.FromFile(monkey.FullName);
                    break;
                case 1:
                    chineseZodiac = "Rooster";
                    Image roosterImg = Image.FromFile(rooster.FullName);
                    break;
                case 2:
                    chineseZodiac = "Dog";
                    Image dogImg = Image.FromFile(dog.FullName);
                    break;
                case 3:
                    chineseZodiac = "Pig";
                    Image pigImg = Image.FromFile(pig.FullName);
                    break;
                case 4:
                    chineseZodiac = "Rat";
                    Image ratImg = Image.FromFile(rat.FullName);
                    break;
                case 5:
                    chineseZodiac = "Ox";
                    Image oxImg = Image.FromFile(ox.FullName);
                    break;
                case 6:
                    chineseZodiac = "Tiger";
                    Image tigerImg = Image.FromFile(tiger.FullName);
                    break;
                case 7:
                    chineseZodiac = "Rabbit";
                    Image rabbitImg = Image.FromFile(rabbit.FullName);
                    break;
                case 8:
                    chineseZodiac = "Dragon";
                    Image dragonImg = Image.FromFile(dragon.FullName);
                    break;
                case 9:
                    chineseZodiac = "Snake";
                    Image snakeImg = Image.FromFile(snake.FullName);
                    break;
                case 10:
                    chineseZodiac = "Horse";
                    Image horseImg = Image.FromFile(horse.FullName);
                    break;
                case 11:
                    chineseZodiac = "Goat";
                    Image goatImg = Image.FromFile(goat.FullName);
                    break;
            }
        }

        private void getHoroscope()
        {
            // Horoscope Values
            if ((birthMonth == 3 && birthDate >= 21) || (birthMonth == 4 && birthDate <= 19))
            {
                horoscope = "Aries";
            }
            else if ((birthMonth == 4 && birthDate >= 20) || (birthMonth == 5 && birthDate <= 20))
            {
                horoscope = "Taurus";
            }
            else if ((birthMonth == 5 && birthDate >= 21) || (birthMonth == 6 && birthDate <= 20))
            {
                horoscope = "Gemini";
            }
            else if ((birthMonth == 5 && birthDate >= 21) || (birthMonth == 6 && birthDate <= 22))
            {
                horoscope = "Cancer";
            }
            else if ((birthMonth == 7 && birthDate >= 23) || (birthMonth == 8 && birthDate <= 22))
            {
                horoscope = "Leo";
            }
            else if ((birthMonth == 8 && birthDate >= 23) || (birthMonth == 9 && birthDate <= 22))
            {
                horoscope = "Virgo";
            }
            else if ((birthMonth == 9 && birthDate >= 23) || (birthMonth == 10 && birthDate <= 22))
            {
                horoscope = "Libra";
            }
            else if ((birthMonth == 10 && birthDate >= 23) || (birthMonth == 11 && birthDate <= 21))
            {
                horoscope = "Scorpio";
            }
            else if ((birthMonth == 11 && birthDate >= 22) || (birthMonth == 12 && birthDate <= 21))
            {
                horoscope = "Sagittarius";
            }
            else if ((birthMonth == 12 && birthDate >= 22) || (birthMonth == 1 && birthDate <= 19))
            {
                horoscope = "Capricorn";
            }
            else if ((birthMonth == 1 && birthDate >= 20) || (birthMonth == 2 && birthDate <= 18))
            {
                horoscope = "Aquarius";
            }
            else if ((birthMonth == 2 && birthDate >= 19) || (birthMonth == 3 && birthDate <= 20))
            {
                horoscope = "Pisces";
            }
        }

        public zodiacForm()
        {
            InitializeComponent();
            
            /*
            Car c = new Car("Honda");
            c.drive();


            string x = Car.FormatNumber("1000");
            
            Console.WriteLine(x);
            */
        }

        private void zodiacForm_Load(object sender, EventArgs e)
        {
            // Initialize
            MaximizeBox = false;
            fullNameText.ForeColor = Color.Gray;
            fullNameText.Text = "Enter your name..";
        }

        private void defaultProgramImage_Click(object sender, EventArgs e)
        {

        }

        private void fullNameText_Enter(object sender, EventArgs e)
        {
            // Clear error
            fullNameErr.Text = String.Empty;

            if (fullNameText.Text == "Enter your name..")
            {
                fullNameText.Text = String.Empty;
            }
        }

        private void fullNameText_Leave(object sender, EventArgs e)
        {
            if (fullNameText.Text == String.Empty)
            {
                fullNameText.Text = "Enter your name..";
            }

            // Validate
            if (!alpha.IsMatch(fullNameText.Text))
            {
                fullNameErr.Text = "* Must not contain invalid characters";
            }
            else if (fullNameText.Text == "Enter your name..")
            {
                fullNameErr.Text = fieldEmptyErr;
            }
            else
            {
                fullName = fullNameText.Text;

                // Sanitize white spaces
                RegexOptions space = RegexOptions.None;
                Regex sanitizeWhiteSpace = new Regex("[ ]{2,}", space);
                fullName = sanitizeWhiteSpace.Replace(fullName, " ");
            }
        }

        private void dateTimePickerSelect_ValueChanged(object sender, EventArgs e)
        {
            // Get numeric values of datetime picker
            birthMonth = dateTimePickerSelect.Value.Month;
            birthDate = dateTimePickerSelect.Value.Day;
            birthYear = dateTimePickerSelect.Value.Year;

            // Output format on the textbox
            dateTimePickerSelect.CustomFormat = "MMM dd, yyyy";
            dateTimePickerSelect.Format = DateTimePickerFormat.Custom;
            dateTimePickerText.Text = dateTimePickerSelect.Text;
        }

        private void dateTimePickerText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            if (((fullNameText.Text == "Enter your name..") && (fullNameText.Text != null)) && (dateTimePickerText.Text == String.Empty))
            {
                fullNameErr.Text = fieldEmptyErr;
                dateTimeErr.Text = fieldEmptyErr;
                MessageBox.Show("You must enter values on required fields", "Error");
            }
            else if (fullNameText.Text == "Enter your name..")
            {
                fullNameErr.Text = fieldEmptyErr;
                MessageBox.Show("You must enter a name", "Error");
            }
            else if (dateTimePickerText.Text == String.Empty)
            {
                dateTimeErr.Text = fieldEmptyErr;
                MessageBox.Show("You must enter a valid date", "Error");
            }
            else
            {
                // Print Values
                getHoroscope();
                getChineseZodiac();

                fullNameResultLabel.Text = String.Format("Full Name: {0}", fullName);
                birthDayResultLabel.Text = String.Format("Birthday: {0}", dateTimePickerSelect.Text);
                zodiacResultLabel.Text = String.Format("{0}", horoscope);
                cZodiacResultLabel.Text = String.Format("{0}", chineseZodiac);

                // Check for zodiac
                if (chineseZodiac == "Monkey")
                {
                    zodiacPickerBox.Image = Image.FromFile(monkey.FullName);
                }
                else if (chineseZodiac == "Rooster")
                {
                    zodiacPickerBox.Image = Image.FromFile(rooster.FullName);
                }
                else if (chineseZodiac == "Dog")
                {
                    zodiacPickerBox.Image = Image.FromFile(dog.FullName);
                }
                else if (chineseZodiac == "Pig")
                {
                    zodiacPickerBox.Image = Image.FromFile(pig.FullName);
                }
                else if (chineseZodiac == "Rat")
                {
                    zodiacPickerBox.Image = Image.FromFile(rat.FullName);
                }
                else if (chineseZodiac == "Ox")
                {
                    zodiacPickerBox.Image = Image.FromFile(ox.FullName);
                }
                else if (chineseZodiac == "Tiger")
                {
                    zodiacPickerBox.Image = Image.FromFile(tiger.FullName);
                }
                else if (chineseZodiac == "Rabbit")
                {
                    zodiacPickerBox.Image = Image.FromFile(rabbit.FullName);
                }
                else if (chineseZodiac == "Dragon")
                {
                    zodiacPickerBox.Image = Image.FromFile(dragon.FullName);
                }
                else if (chineseZodiac == "Snake")
                {
                    zodiacPickerBox.Image = Image.FromFile(snake.FullName);
                }
                else if (chineseZodiac == "Horse")
                {
                    zodiacPickerBox.Image = Image.FromFile(horse.FullName);
                }
                else if (chineseZodiac == "Goat")
                {
                    zodiacPickerBox.Image = Image.FromFile(goat.FullName);
                }

                // Check horoscope
                if (horoscope == "Aries")
                {
                    horoscopePickerBox.Image = Image.FromFile(aries.FullName);
                }
                else if (horoscope == "Taurus")
                {
                    horoscopePickerBox.Image = Image.FromFile(taurus.FullName);
                }
                else if (horoscope == "Gemini")
                {
                    horoscopePickerBox.Image = Image.FromFile(gemini.FullName);
                }
                else if (horoscope == "Cancer")
                {
                    horoscopePickerBox.Image = Image.FromFile(cancer.FullName);
                }
                else if (horoscope == "Leo")
                {
                    horoscopePickerBox.Image = Image.FromFile(leo.FullName);
                }
                else if (horoscope == "Virgo")
                {
                    horoscopePickerBox.Image = Image.FromFile(virgo.FullName);
                }
                else if (horoscope == "Libra")
                {
                    horoscopePickerBox.Image = Image.FromFile(libra.FullName);
                }
                else if (horoscope == "Scorpio")
                {
                    horoscopePickerBox.Image = Image.FromFile(scorpio.FullName);
                }
                else if (horoscope == "Sagittarius")
                {
                    horoscopePickerBox.Image = Image.FromFile(sagittarius.FullName);
                }
                else if (horoscope == "Capricorn")
                {
                    horoscopePickerBox.Image = Image.FromFile(capricorn.FullName);
                }
                else if (horoscope == "Aquarius")
                {
                    horoscopePickerBox.Image = Image.FromFile(aquarius.FullName);
                }
                else if (horoscope == "Pisces")
                {
                    horoscopePickerBox.Image = Image.FromFile(pisces.FullName);
                }
            }
        }
    }
}