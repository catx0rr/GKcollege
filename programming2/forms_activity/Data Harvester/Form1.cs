using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

namespace Data_Harvester
{
    public partial class DataHarvesterForm : Form
    {
        // Global variables
        public static string getLastName,
               getGivenName,
               getMiddleName,
               getHouseBlkNo,
               getStreet,
               getCityName,
               getZipCode,
               getTelNo,
               getCellNo,
               getGender,
               getHeight,
               getWeight,
               getMonth,
               getDay,
               getYear,
               getEducation,
               getSkills,
               getLanguage;

        string error = "* Required";
        string required = "Required Fields must not be empty";

        // Regular expression
        Regex alpha = new Regex("^[a-zA-Z \f\n\r\t\v]*$"); // with whitespace
        Regex special= new Regex("^[a-zA-Z0-9 ]*$"); // catch special characters
        Regex specialExcept = new Regex("^[a-zA-Z0-9 ^.^,]*$"); // catch special characters except dot
        Regex specialNum= new Regex("^[a-zA-Z]*$");
        Regex num = new Regex("^[0-9]*$");

        // Date time Values
        DateTime dateNow = DateTime.Now;

        int monthSelected,
            daySelected,
            yearSelected;

        int currentMonth,
            currentDay,
            currentYear,
            age;

        // Get Skills empty array
        List<string> addSkills = new List<string>();

        // Get Languages empty array
        List<string> addLanguage = new List<string>();

        // BMI conversion
        int convertCmtoM;
        float BMI;

        // City Values
        string[] cities =
        {
            "caloocan",
            "las pinas",
            "makati",
            "malabon",
            "mandaluyong",
            "manila",
            "marikina",
            "muntinlupa",
            "navotas",
            "parañaque",
            "pasay",
            "pasig",
            "pateros",
            "quezon city",
            "san juan",
            "taguig",
            "valenzuela"
        };

        // Months
        string[] months =
        {
            "january",
            "february",
            "march",
            "april",
            "may",
            "june",
            "july",
            "august",
            "september",
            "october",
            "november",
            "december"
        };

        string[] techSkills =
        {
            "programming",
            "network",
            "multimedia",
            "technical"
        };

        string[] progLangs =
        {
            "c",
            "c++",
            "c#",
            "java",
            "vb.net",
            "c#.net",
            "python"
        };

        private void DataHarvesterForm_Load(object sender, EventArgs e)
        {
            // Cities comboBox
            foreach (string city in cities)
            {
                citySelectCombo.Items.Add(city.ToUpper());
                citySelectCombo.ForeColor = Color.Gray;
            }

            // Month comboBox
            foreach (string month in months)
            {
                // Capitalize the first string
                monthSelectCombo.Items.Add(char.ToUpper(month[0]) + month.Substring(1));
                monthSelectCombo.ForeColor = Color.Gray;
            }

            // Day comboBox
            for (int day = 1; day <= 31; day++)
            {
                daySelectCombo.Items.Add(day);
                yearSelectCombo.ForeColor = Color.Gray;
            }

            // Year comboBox
            for (int year = 2020; year >= 1970; year--)
            {
                yearSelectCombo.Items.Add(year);
                yearSelectCombo.ForeColor = Color.Gray;
            }

            // Tech skills
            foreach (string techSkill in techSkills)
            {
                // Capitalize the first string
                skillsCheckedList.Items.Add(char.ToUpper(techSkill[0]) + techSkill.Substring(1));
            }

            // Programming Language
            foreach (string progLang in progLangs)
            {
                // Capitalize the first string
                if ((progLang != "vb.net") && (progLang != "c#.net"))
                {
                    progLangCheckedList.Items.Add(char.ToUpper(progLang[0]) + progLang.Substring(1));
                }
                else
                {
                    progLangCheckedList.Items.Add(progLang.ToUpper());
                }

            }

            // Disabled textBoxes
            bmiOutputText.Enabled = false;
            ageText.Enabled = false;
            telCountryCodeText.Enabled = false;
            cellCountryCodeText.Enabled = false;
        }

        private void cleanForm()
        {
            // Clear the values of text boxes
            lastNameText.Clear();
            givenNameText.Clear();
            middleNameText.Clear();
            houseBlkText.Clear();
            streetText.Clear();
            citySelectCombo.Text = "City";
            citySelectCombo.ForeColor = Color.Gray;
            zipCodeText.Clear();
            telNoText.Clear();
            cellNoText.Clear();
            maleRadio.Checked = false;
            femaleRadio.Checked = false;
            heightCmText.Clear();
            weightKgText.Clear();
            bmiOutputText.Clear();
            monthSelectCombo.Text = "Month";
            monthSelectCombo.ForeColor = Color.Gray;
            daySelectCombo.Text = "Day";
            daySelectCombo.ForeColor = Color.Gray;
            yearSelectCombo.Text = "Year";
            yearSelectCombo.ForeColor = Color.Gray;
            ageText.Clear();
            highschoolRadio.Checked = false;
            undergradRadio.Checked = false;
            gradCollegeRadio.Checked = false;
            postGradRadio.Checked = false;

            foreach (int item in skillsCheckedList.CheckedIndices)
            {
                skillsCheckedList.SetItemCheckState(item, CheckState.Unchecked);
            }

            foreach (int item in progLangCheckedList.CheckedIndices)
            {
                progLangCheckedList.SetItemCheckState(item, CheckState.Unchecked);
            }
        }
            public DataHarvesterForm()
        {
            InitializeComponent();
        }


        // Name Boxes
        private void lastNameText_Enter(object sender, EventArgs e)
        {
            if (lastNameText.Text == "Last Name")
            {
                lastNameText.Text = String.Empty;
                lastNameText.ForeColor = Color.Black;
            }

            // Clear Validation
            lastNameErr.Text = null;
        }

        private void lastNameText_Leave(object sender, EventArgs e)
        {
            if (lastNameText.Text == String.Empty)
            {
                lastNameText.Text = "Last Name";
                lastNameText.ForeColor = Color.Gray;
            }

            // Last name validation
            if (lastNameText.Text == "Last Name")
            {
                lastNameErr.Text = "* Required";
            }

            else if ((lastNameText.TextLength < 3) || (lastNameText.TextLength > 20))
            {
                lastNameErr.Text = "* Must be 3-20 characters long";
            }
            else if (!alpha.IsMatch(lastNameText.Text))
            {
                lastNameErr.Text = "* Must not contain numbers and special characters";
            }
            else
            {
                getLastName = lastNameText.Text;

                // Sanitize white spaces
                RegexOptions space = RegexOptions.None;
                Regex sanitizeWhiteSpace = new Regex("[ ]{2,}", space);
                getLastName = sanitizeWhiteSpace.Replace(getLastName, " ");
            }
        }


        private void givenNameText_Enter(object sender, EventArgs e)
        {
            if (givenNameText.Text == "Given Name")
            {
                givenNameText.Text = String.Empty;
                givenNameText.ForeColor = Color.Black;
            }

            // Clear Validation
            givenNameErr.Text = null;
        }

        private void givenNameText_Leave(object sender, EventArgs e)
        {
            if (givenNameText.Text == String.Empty)
            {
                givenNameText.Text = "Given Name";
                givenNameText.ForeColor = Color.Gray;
            }

            // Given name validation
            if (givenNameText.Text == "Given Name")
            {
                givenNameErr.Text = "* Required";
            }

            else if ((givenNameText.TextLength < 2) || (givenNameText.TextLength > 20))
            {
                givenNameErr.Text = "* Must be 2-20 characters long";
            }
            else if (!alpha.IsMatch(givenNameText.Text))
            {
                givenNameErr.Text = "* Must not contain numbers and special characters";
            }
            else
            {
                getGivenName = givenNameText.Text;

                // Sanitize white spaces
                RegexOptions space = RegexOptions.None;
                Regex sanitizeWhiteSpace = new Regex("[ ]{2,}", space);
                getGivenName = sanitizeWhiteSpace.Replace(getGivenName, " ");
            }
        }


        private void middleNameText_Enter(object sender, EventArgs e)
        {
            if (middleNameText.Text == "Middle Name")
            {
                middleNameText.Text = String.Empty;
                middleNameText.ForeColor = Color.Black;
            }

            // Clear Validation
            middleNameErr.Text = null;
        }

        private void middleNameText_Leave(object sender, EventArgs e)
        {
            if (middleNameText.Text == String.Empty)
            {
                middleNameText.Text = "Middle Name";
                middleNameText.ForeColor = Color.Gray;
            }

            // Middle name validation
            if (middleNameText.Text == "Middle Name")
            {
                middleNameErr.Text = "* Required";
            }

            else if ((middleNameText.TextLength < 3 || (middleNameText.TextLength > 20)))
            {
                middleNameErr.Text = "* Must be 3-20 characters long";
            }

            else if (!alpha.IsMatch(middleNameText.Text))
            {
                middleNameErr.Text = "* Must not contain numbers and special characters";
            }
            else
            {
                getMiddleName = middleNameText.Text;

                // Sanitize white spaces
                RegexOptions space = RegexOptions.None;
                Regex sanitizeWhiteSpace = new Regex("[ ]{2,}", space);
                getMiddleName = sanitizeWhiteSpace.Replace(getMiddleName, " ");
            }
        }


        private void uploadBtn_Click(object sender, EventArgs e)
        {

            // Select  a file
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp;)|*.png; *.jpg; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(open.FileName);
                picNoteLabel.Text = null;
            }
        }


        private void houseBlkText_Enter(object sender, EventArgs e)
        {
            if (houseBlkText.Text == "House / Blk No.")
            {
                houseBlkText.Text = String.Empty;
                houseBlkText.ForeColor = Color.Black;

            }

            // Clear validation
            houseBlkErr.Text = null;
        }

        private void houseBlkText_Leave(object sender, EventArgs e)
        {
            if (houseBlkText.Text == String.Empty)
            {
                houseBlkText.Text = "House / Blk No.";
                houseBlkText.ForeColor = Color.Gray;

            }

            // House Blk
            if (houseBlkText.Text == "House / Blk No.")
            {
                houseBlkErr.Text = "* Required";
            }

            else if (!num.IsMatch(houseBlkText.Text))
            {
                houseBlkErr.Text = "* Must be a number";
            }
            else
            {
                getHouseBlkNo = houseBlkText.Text;
            }
        }

        private void streetText_Enter(object sender, EventArgs e)
        {
            if (streetText.Text == "Street")
            {
                streetText.Text = String.Empty;
                streetText.ForeColor = Color.Black;
            }

            // Clear validation
            streetErr.Text = null;
        }

        private void streetText_Leave(object sender, EventArgs e)
        {
            if (streetText.Text == String.Empty)
            {
                streetText.Text = "Street";
                streetText.ForeColor = Color.Gray;
            }

            // Street validation
            if (streetText.Text == "Street")
            {
                streetErr.Text = "* Required";
            }
            else if (!specialExcept.IsMatch(streetText.Text))
            {
                streetErr.Text = "* Must not contain special characters";
            }
            else
            {
                getStreet = streetText.Text;

                // Sanitize white spaces
                RegexOptions space = RegexOptions.None;
                Regex sanitizeWhiteSpace = new Regex("[ ]{2,}", space);
                getStreet = sanitizeWhiteSpace.Replace(getStreet, " ");

                // Sanitize dots
                RegexOptions dots = RegexOptions.None;
                Regex sanitizeDots = new Regex("[.]{2,}", dots);
                getStreet = sanitizeDots.Replace(getStreet, ".");

                // Sanitize commas
                RegexOptions comma = RegexOptions.None;
                Regex sanitizeCommas = new Regex("[,]{2,}", comma);
                getStreet = sanitizeCommas.Replace(getStreet, ",");
            }

        }

        private void citySelectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Parse the selected city
            getCityName = Convert.ToString(citySelectCombo.SelectedItem);
        }

        private void citySelectCombo_Enter(object sender, EventArgs e)
        {
            citySelectCombo.ForeColor = Color.Black;

            // Clear validation
            cityErr.Text = null;
        }

        private void citySelectCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Disable keypress
            e.Handled = true;
        }

        private void citySelectCombo_Leave(object sender, EventArgs e)
        {
            citySelectCombo.ForeColor = Color.Gray;

            if (citySelectCombo.Text == String.Empty)
            {
                citySelectCombo.ForeColor = Color.Gray;
                citySelectCombo.Text = "City";
            }

            // City validation
            if (citySelectCombo.Text == "City")
            {
                cityErr.Text = "* Required";
            }

            // City validation if null
            if (citySelectCombo.SelectedItem != null)
            {
                citySelectCombo.ForeColor = Color.Black;
                getCityName = Convert.ToString(citySelectCombo.SelectedItem);
            }
            else if (!specialNum.IsMatch(citySelectCombo.Text))
            {
                cityErr.Text = "Must not contain number or special character";
            }
            else
            {
                getCityName = citySelectCombo.Text;
            }
        }


        private void zipCodeText_Enter(object sender, EventArgs e)
        {
            if (zipCodeText.Text == "Zip Code")
            {
                zipCodeText.Text = String.Empty;
                zipCodeText.ForeColor = Color.Black;
            }

            // Clear validation
            zipCodeErr.Text = null;
        }

        private void zipCodeText_Leave(object sender, EventArgs e)
        {
            if (zipCodeText.Text == String.Empty)
            {
                zipCodeText.Text = "Zip Code";
                zipCodeText.ForeColor = Color.Gray;
            }

            // Zip code validation

            if (zipCodeText.Text == "Zip Code")
            {
                zipCodeErr.Text = "* Required";
            }
            else if ((zipCodeText.TextLength < 4) || (zipCodeText.TextLength > 4))
            {
                zipCodeErr.Text = "* Zip code must 4 digits long";
            }
            else if (!num.IsMatch(zipCodeText.Text))
            {
                zipCodeErr.Text = "* Must be a number";
            }
            else
            {
                getZipCode = zipCodeText.Text;
            }
        }


        private void telNoText_Enter(object sender, EventArgs e)
        {
            if (telNoText.Text == "Telephone No.")
            {
                telNoText.Text = String.Empty;
                telNoText.ForeColor = Color.Black;
            }

            // Clear validation
            telNoErr.Text = null;
        }

        private void telNoText_Leave(object sender, EventArgs e)
        {
            if (telNoText.Text == String.Empty)
            {
                telNoText.Text = "Telephone No.";
                telNoText.ForeColor = Color.Gray;
            }

            // Telephone number validation
            if (telNoText.Text == "Telephone No.")
            {
                telNoErr.Text = "* Required";
            }
            else if ((!num.IsMatch(telNoText.Text)))
            {
                telNoErr.Text = "* Must be a number";
            }
            else if ((telNoText.TextLength < 7) || (telNoText.TextLength > 7))
            {
                telNoErr.Text = "* Must be 7 digits long";
            }
            else
            {
                getTelNo = telCountryCodeText.Text + telNoText.Text;
            }
        }


        private void cellNoText_Enter(object sender, EventArgs e)
        {
            if (cellNoText.Text == "Cellphone No.")
            {
                cellNoText.Text = String.Empty;
                cellNoText.ForeColor = Color.Black;
            }

            // Clear validation
            cellNoErr.Text = null;
        }

        private void cellNoText_Leave(object sender, EventArgs e)
        {
            if (cellNoText.Text == String.Empty)
            {
                cellNoText.Text = "Cellphone No.";
                cellNoText.ForeColor = Color.Gray;
            }

            // Cellphone number validation
            if (cellNoText.Text == "Cellphone No.")
            {
                cellNoErr.Text = "* Required";
            }
            else if ((!num.IsMatch(cellNoText.Text)))
            {
                cellNoErr.Text = "* Must be a number";
            }
            else if ((cellNoText.TextLength < 9) || (cellNoText.TextLength > 9))
            {
                cellNoErr.Text = "* Must be 9 digits long";
            }
            else
            {
                getCellNo = cellCountryCodeText.Text + cellNoText.Text;
            }
        }


        private void maleRadio_Click(object sender, EventArgs e)
        {
            if (maleRadio.Checked)
            {
                getGender = maleRadio.Text;
            }

        }

        private void femaleRadio_Click(object sender, EventArgs e)
        {
            if (femaleRadio.Checked)
            {
                getGender = femaleRadio.Text;
            }

        }

        private void genderGroup_Enter(object sender, EventArgs e)
        {
            // Clear validation
            genderErr.Text = null;
        }

        private void genderGroup_Leave(object sender, EventArgs e)
        {
            if (!maleRadio.Checked && !femaleRadio.Checked)
            {
                genderErr.Text = "* Required";
            }
        }

        private void heightCmText_TextChanged(object sender, EventArgs e)
        {

        }

        private void heightCmText_Enter(object sender, EventArgs e)
        {
            if (heightCmText.Text == "cm")
            {
                heightCmText.Text = String.Empty;
                heightCmText.ForeColor = Color.Black;
            }

            // Clear validation
            heightErr.Text = null;
        }

        private void heightCmText_Leave(object sender, EventArgs e)
        {
            if (heightCmText.Text == String.Empty)
            {
                heightCmText.Text = "cm";
                heightCmText.ForeColor = Color.Gray;
            }

            // Height validation
            if (heightCmText.Text == "cm")
            {
                heightErr.Text = "* Required";
                bmiOutputText.Text = String.Empty;
            }
            else if (heightCmText.TextLength >= 4)
            {
                heightErr.Text = "* Invalid height values";
                bmiOutputText.Text = String.Empty;
            }
            else if ((!num.IsMatch(heightCmText.Text)))
            {
                heightErr.Text = "* Must be a number";
                bmiOutputText.Text = String.Empty;
            }
            else
            {
                getHeight = heightCmText.Text;
            }

            // Calculate bmi
            if ((weightKgText.Text != "kg") && (heightCmText.Text != "cm"))
            {
                if ((num.IsMatch(heightCmText.Text) && (num.IsMatch(weightKgText.Text))))
                {
                    // Calculate Body mass Index
                    convertCmtoM = (Convert.ToInt32(getHeight) / 100);
                    BMI = (Convert.ToInt32(getWeight) / (convertCmtoM ^ 2));

                    // Display values
                    bmiOutputText.Text = Convert.ToString(BMI);
                }
                else if ((num.IsMatch(heightCmText.Text) || (num.IsMatch(weightKgText.Text))))
                {
                    bmiOutputText.Text = String.Empty;
                }
            }
        }


        private void weightKgText_Enter(object sender, EventArgs e)
        {
            if (weightKgText.Text == "kg")
            {
                weightKgText.Text = String.Empty;
                weightKgText.ForeColor = Color.Black;
            }

            // Clear validation
            weightErr.Text = null;
        }

        private void weightKgText_Leave(object sender, EventArgs e)
        {
            if (weightKgText.Text == string.Empty)
            {
                weightKgText.Text = "kg";
                weightKgText.ForeColor = Color.Gray;

            }

            // Weight validation
            if (weightKgText.Text == "kg")
            {
                weightErr.Text = "* Required";
            }
            else if (weightKgText.TextLength >= 4)
            {
                weightErr.Text = "* Invalid weight values";
            }
            else if ((!num.IsMatch(weightKgText.Text)))
            {
                weightErr.Text = "* Must be a number";
            }
            else
            {
                getWeight = weightKgText.Text;
            }

            // Calculate bmi
            if ((weightKgText.Text != "kg") && (heightCmText.Text != "cm"))
            {
                if ((num.IsMatch(heightCmText.Text) && (num.IsMatch(weightKgText.Text))))
                {
                    // Calculate Body mass Index
                    if ((Convert.ToInt32(getHeight) != 0) && (Convert.ToInt32(getWeight) != 0))
                    {
                        convertCmtoM = (Convert.ToInt32(getHeight) / 100);
                        BMI = (Convert.ToInt32(getWeight) / (convertCmtoM ^ 2));

                        // Display values
                        bmiOutputText.Text = Convert.ToString(BMI);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Height or Weight values");
                    }

                }
                else if ((num.IsMatch(heightCmText.Text) || (num.IsMatch(weightKgText.Text))))
                {
                    bmiOutputText.Text = String.Empty;
                }
            }

        }

        private void monthSelectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Parse the value of the selected month
            monthSelected = Convert.ToInt32(monthSelectCombo.SelectedIndex) + 1;
            monthSelectCombo.ForeColor = Color.Black;

            // Calculate age
            currentMonth = (dateNow.Month - monthSelected);
            currentDay = (dateNow.Day - daySelected);
            currentYear = (dateNow.Year - yearSelected);

            // Validate the age if birthday
            if ((currentMonth <= 0) && (currentDay <= 0))
            {
                age = currentYear - 1;
            }
            else
            {
                age = currentYear;
            }

            if (age < 0)
            {
                // Clear values of birthday combo box

                monthSelectCombo.ForeColor = Color.Gray;
                monthSelectCombo.Text = Convert.ToString(monthSelectCombo.SelectedItem);
                daySelectCombo.ForeColor = Color.Gray;
                daySelectCombo.Text = Convert.ToString(daySelectCombo.SelectedItem);
                yearSelectCombo.ForeColor = Color.Gray;
                yearSelectCombo.Text = Convert.ToString(yearSelectCombo.SelectedItem);

                MessageBox.Show("Please select a valid date of birth");
                ageText.Text = String.Empty;
            }
            else if ((monthSelectCombo.SelectedItem == null) && (daySelectCombo.SelectedItem == null) && (yearSelectCombo.SelectedItem == null))
            {
                ageText.Text = String.Empty;
            }
            else if ((monthSelectCombo.Text != "Month") && (daySelectCombo.Text != "Day") && (yearSelectCombo.Text != "Year"))
            {
                ageText.Text = age.ToString();
            }
        }

        private void monthSelectCombo_Enter(object sender, EventArgs e)
        {
            monthSelectCombo.ForeColor = Color.Black;

            // Clear Validation
            monthErr.Text = null;
        }

        private void monthSelectCombo_Leave(object sender, EventArgs e)
        {
            monthSelectCombo.ForeColor = Color.Gray;

            // Month validation if matches with invalid input
            if (monthSelectCombo.Text == String.Empty)
            {
                monthSelectCombo.Text = "Month";
            }

            else if (monthSelectCombo.Text == "Month")
            {
                monthErr.Text = "* Required";
            }
            else if (!specialNum.IsMatch(monthSelectCombo.Text))
            {
                monthErr.Text = "* Must be a month word";
            }
            else if ((monthSelectCombo.SelectedItem != null) || (monthSelectCombo.Text != null))
            {
                monthSelectCombo.ForeColor = Color.Black;
                getMonth = Convert.ToString(monthSelectCombo.SelectedItem);
            }
            else if (monthSelectCombo.Text == "2020" && monthSelectCombo.Text == "Month" && daySelectCombo.Text == "Year")
            {
                MessageBox.Show("Please select a valid year");
            }
            else
            {
                monthSelected = Convert.ToInt32(daySelectCombo.Text); ;
            }
        }

        private void monthSelectCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Disable keypress
            e.Handled = true;
        }

        private void daySelectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Parse the value of the selected day
            daySelected = Convert.ToInt32(daySelectCombo.SelectedItem) - 1;
            daySelectCombo.ForeColor = Color.Black;

            // Calculate age
            currentMonth = (dateNow.Month - monthSelected);
            currentDay = (dateNow.Day - daySelected);
            currentYear = (dateNow.Year - yearSelected);

            // Validate the age if birthday
            if ((currentMonth <= 0) && (currentDay <= 0))
            {
                age = currentYear - 1;
            }
            else
            {
                age = currentYear;
            }

            if (age < 0)
            {
                // Clear values of birthday combo box

                monthSelectCombo.ForeColor = Color.Gray;
                monthSelectCombo.Text = Convert.ToString(monthSelectCombo.SelectedItem);
                daySelectCombo.ForeColor = Color.Gray;
                daySelectCombo.Text = Convert.ToString(daySelectCombo.SelectedItem);
                yearSelectCombo.ForeColor = Color.Gray;
                yearSelectCombo.Text = Convert.ToString(yearSelectCombo.SelectedItem);

                MessageBox.Show("Please select a valid date of birth");
                ageText.Text = String.Empty;
            }
            else if ((monthSelectCombo.SelectedItem == null) && (daySelectCombo.SelectedItem == null) && (yearSelectCombo.SelectedItem == null))
            {
                ageText.Text = String.Empty;
            }
            else if ((monthSelectCombo.Text != "Month") && (daySelectCombo.Text != "Day") && (yearSelectCombo.Text != "Year"))
            {
                ageText.Text = age.ToString();
            }
        }

        private void daySelectCombo_Enter(object sender, EventArgs e)
        {
            daySelectCombo.ForeColor = Color.Black;

            // Clear validation
            dayErr.Text = null;
        }

        private void daySelectCombo_Leave(object sender, EventArgs e)
        {
            daySelectCombo.ForeColor = Color.Gray;

            // Day validation if matches with invalid input
            if (daySelectCombo.Text == String.Empty)
            {
                daySelectCombo.Text = "Day";
            }
            else if (daySelectCombo.Text == "Day")
            {
                dayErr.Text = "* Required";
            }
            else if (!num.IsMatch(daySelectCombo.Text))
            {
                dayErr.Text = "* Must be a number";
            }
            else if ((Convert.ToInt32(daySelectCombo.Text) <= 0))
            {
                dayErr.Text = "* Must not be equal to 0";
            }
            else if ((Convert.ToInt32(daySelectCombo.Text) > 31))
            {
                dayErr.Text = "* Must not exceed to 31";
            }
            else if ((daySelectCombo.SelectedItem != null) || (daySelectCombo.Text != null))
            {
                daySelectCombo.ForeColor = Color.Black;
                getDay = Convert.ToString(daySelectCombo.SelectedItem);
            }
            else
            {
                daySelected = Convert.ToInt32(daySelectCombo.Text);
            }
        }

        private void daySelectCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Disable keypress
            e.Handled = true;
        }

        private void yearSelectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Parse value of selected year
            yearSelected = Convert.ToInt32(yearSelectCombo.SelectedItem);

            // Calculate age
            currentMonth = (dateNow.Month - monthSelected);
            currentDay = (dateNow.Day - daySelected);
            currentYear = (dateNow.Year - yearSelected);

            // Validate the age if birthday
            if ((currentMonth <= 0) && (currentDay <= 0))
            {
                age = currentYear - 1;
            }
            else
            {
                age = currentYear;
            }

            if (age < 0)
            {
                // Clear values of birthday combo box

                monthSelectCombo.ForeColor = Color.Gray;
                monthSelectCombo.Text = Convert.ToString(monthSelectCombo.SelectedItem);
                daySelectCombo.ForeColor = Color.Gray;
                daySelectCombo.Text = Convert.ToString(daySelectCombo.SelectedItem);
                yearSelectCombo.ForeColor = Color.Gray;
                yearSelectCombo.Text = Convert.ToString(yearSelectCombo.SelectedItem);

                MessageBox.Show("Please select a valid date of birth");
                ageText.Text = String.Empty;
                yearSelectCombo.Text = "Year";
            }
            else if ((monthSelectCombo.SelectedItem == null) && (daySelectCombo.SelectedItem == null) && (yearSelectCombo.SelectedItem == null))
            {
                ageText.Text = String.Empty;
            }
            else if ((monthSelectCombo.Text != "Month") && (daySelectCombo.Text != "Day") && (yearSelectCombo.Text != "Year"))
            {
                ageText.Text = age.ToString();
            }
        }
        private void yearSelectCombo_Enter(object sender, EventArgs e)
        {
            yearSelectCombo.ForeColor = Color.Black;

            // Clear validation
            yearErr.Text = null;
        }

        private void yearSelectCombo_Leave(object sender, EventArgs e)
        {
            yearSelectCombo.ForeColor = Color.Gray;

            // Year validation if matches with invalid input
            if (yearSelectCombo.Text == "Year")
            {
                yearErr.Text = "* Required";
            }
            else if (!num.IsMatch(yearSelectCombo.Text))
            {
                yearErr.Text = "* Must be a number";
            }
            else if ((Convert.ToInt32(yearSelectCombo.Text) <= 0))
            {
                yearErr.Text = "* Must not be equal to 0";
            }
            else if ((Convert.ToInt32(yearSelectCombo.Text) < 1970 || (Convert.ToInt32(yearSelectCombo.Text) > 2020)))
            {
                yearErr.Text = "* Must between 1970 to 2020";
            }
            else if ((yearSelectCombo.SelectedItem != null) || (yearSelectCombo.Text != null))
            {
                yearSelectCombo.ForeColor = Color.Black;
                getYear = Convert.ToString(yearSelectCombo.SelectedItem);
            }
            else if (yearSelectCombo.Text == "2020" && monthSelectCombo.Text == "Month" && daySelectCombo.Text == "Year")
            {
                MessageBox.Show("Please select a valid year");
            }
            else
            {
                yearSelected = Convert.ToInt32(yearSelectCombo.Text);
            }
        }

        private void yearSelectCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void highschoolRadio_Click(object sender, EventArgs e)
        {
            if (highschoolRadio.Checked)
            {
                getEducation = highschoolRadio.Text;
            }
        }

        private void undergradRadio_Click(object sender, EventArgs e)
        {
            if (undergradRadio.Checked)
            {
                getEducation = undergradRadio.Text;
            }
        }

        private void gradCollegeRadio_Click(object sender, EventArgs e)
        {
            if (gradCollegeRadio.Checked)
            {
                getEducation = gradCollegeRadio.Text;
            }
        }

        private void postGradRadio_Click(object sender, EventArgs e)
        {
            if (postGradRadio.Checked)
            {
                getEducation = postGradRadio.Text;
            }
            /*
            // Debugger
            Thread.Sleep(1000); // using System.Threading lib
            postGradRadio.Checked = false;
            */
        }

        private void educationGroup_Enter(object sender, EventArgs e)
        {
            // Clear validation
            educationErr.Text = null;
        }

        private void educationGroup_Leave(object sender, EventArgs e)
        {
            if (!highschoolRadio.Checked && !undergradRadio.Checked && !gradCollegeRadio.Checked && !postGradRadio.Checked)
            {
                educationErr.Text = "* Required";
            }
        }

        private void skillsCheckedList_Enter(object sender, EventArgs e)
        {
            // Clear if a value is selected
            if (skillsCheckedList.CheckedItems != null)
            {
                skillsNone.Text = String.Empty;
            }
        }

        private void skillsCheckedList_Leave(object sender, EventArgs e)
        {
            if (skillsCheckedList.CheckedItems == null)
            {
                skillsNone.Text = "No skills selected"; 
            }
        }

        private void progLangCheckedList_Enter(object sender, EventArgs e )
        {
            // Clear if a value is selected
            if (progLangCheckedList.CheckedItems != null)
            {
                progLangsNone.Text = String.Empty;
            }
        }

        private void progLangCheckedList_Leave(object sender, EventArgs e)
        {
            if (progLangCheckedList.CheckedItems == null)
            {
                progLangsNone.Text = "No programming knowledge selected";
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (lastNameText.Text == String.Empty)
            {
                lastNameErr.Text = error;
                MessageBox.Show(required);
            }
            else if (givenNameText.Text == String.Empty)
            {
                givenNameErr.Text = error;
                MessageBox.Show(required);
            }
            else if (middleNameText.Text == String.Empty)
            {
                middleNameErr.Text = error;
                MessageBox.Show(required);
            }
            else if (houseBlkText.Text == String.Empty)
            {
                houseBlkErr.Text = error;
                MessageBox.Show(required);
            }
            else if (streetText.Text == String.Empty)
            {
                streetErr.Text = error;
                MessageBox.Show(required);
            }

            else if (zipCodeText.Text == String.Empty)
            {
                zipCodeErr.Text = error;
                MessageBox.Show(required);
            }
            else if (telNoText.Text == String.Empty)
            {
                telNoErr.Text = error;
                MessageBox.Show(required);
            }
            else if (cellNoText.Text == String.Empty)
            {
                cellNoErr.Text = error;
                MessageBox.Show(required);
            }
            else if (heightCmText.Text == String.Empty)
            {
                heightErr.Text = error;
                MessageBox.Show(required);
            }
            else if (weightKgText.Text == String.Empty)
            {
                weightErr.Text = error;
                MessageBox.Show(required);
            }
            else if (!maleRadio.Checked && !femaleRadio.Checked)
            {
                genderErr.Text = error;
                MessageBox.Show(required);
            }
            else if (citySelectCombo.Text == String.Empty)
            {
                cityErr.Text = error;
                MessageBox.Show(required);
            }
            else if (monthSelectCombo.SelectedItem == null)
            {
                monthErr.Text = error;
                MessageBox.Show(required);
            }
            else if (daySelectCombo.SelectedItem == null)
            {
                dayErr.Text = error;
                MessageBox.Show(required);
            }
            else if (yearSelectCombo.SelectedItem == null)
            {
                yearErr.Text = error;
                MessageBox.Show(required);
            }
            else if (!highschoolRadio.Checked && !undergradRadio.Checked && !gradCollegeRadio.Checked && !postGradRadio.Checked)
            {
                educationErr.Text = error;
                MessageBox.Show(required);
            }
            else if ((!alpha.IsMatch(lastNameText.Text) || (!alpha.IsMatch(givenNameText.Text) || (!alpha.IsMatch(middleNameText.Text)))))
            {
                MessageBox.Show("Invalid values for names");
            }
            else if (
                     (!specialExcept.IsMatch(streetText.Text)) ||
                     (!num.IsMatch(zipCodeText.Text)) ||
                     (!num.IsMatch(houseBlkText.Text)) ||
                     (zipCodeText.TextLength > 4) ||
                     (zipCodeText.TextLength < 4)
                    )
            {
                MessageBox.Show("Invalid values for address");
            }
            else if (
                     (!num.IsMatch(telNoText.Text)) ||
                     (!num.IsMatch(cellNoText.Text)) ||
                     (telNoText.TextLength < 7) ||
                     (telNoText.TextLength > 7) ||
                     (cellNoText.TextLength > 9) ||
                     (cellNoText.TextLength < 9)
                    )
            {
                MessageBox.Show("Invalid values for contact numbers");
            }
            else if ((!num.IsMatch(heightCmText.Text) || (!num.IsMatch(weightKgText.Text))))
            {
                MessageBox.Show("Invalid values for height or weight");
            }
            // Execute the load 
            else
            {
                
                if (skillsCheckedList.CheckedItems.Count > 0)
                {
                    // Store the values of checked items in skills
                    foreach (string item in skillsCheckedList.CheckedItems)
                    {
                        addSkills.Add(item);
                    }

                    getSkills = string.Join(", ", addSkills);
                }
                else
                {
                    getSkills = "None";
                }
                if (progLangCheckedList.CheckedItems.Count > 0)
                {
                    // Store the values of checked items in programming languages
                    foreach (string item in progLangCheckedList.CheckedItems)
                    {
                        addLanguage.Add(item);
                    }

                    getLanguage = string.Join(", ", addLanguage);
                }
                else
                {
                    getLanguage = "None";
                }

                // Output data values
                MessageBox.Show(String.Format("Full Name: {0} {1} {2} \n" +
                "Address: {3} {4} {5} {6}\n" +
                "Contact: {7} / {8} \n" +
                "Gender: {9}\n" +
                "Height: {10}\n" +
                "Weight: {11}\n" +
                "Body Mass Index: {12}\n" +
                "Birthday: {13} {14}, {15}\n" +
                "Age: {16}\n" +
                "Educational Attainment: {17}\n" +
                "Skills: {18}\n" +
                "Programming Languages: {19}",
                getGivenName,
                getMiddleName,
                getLastName,
                getHouseBlkNo,
                getStreet,
                getCityName,
                getZipCode,
                getTelNo,
                getCellNo,
                getGender,
                getHeight,
                getWeight,
                BMI,
                getMonth,
                getDay,
                getYear,
                age,
                getEducation,
                getSkills,
                getLanguage
                ));

                // Clean form afterwards
                cleanForm();

            /* Output to a new form
            https://www.c-sharpcorner.com/UploadFile/834980/how-to-pass-data-from-one-form-to-other-form-in-windows-form/
            */
            }
            
        }

    }

}