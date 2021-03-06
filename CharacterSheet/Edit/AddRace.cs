﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet.Edit
{
    public partial class AddRace : Form
    {
        int fontSize;
        bool beingEdited = false;
        int raceID;
        //DnDataDataSet db;

        public AddRace(int fontSize)
        {
            InitializeComponent();
            this.fontSize = fontSize;
        }

        public AddRace(bool beingEdited, int raceID)
        {
            this.beingEdited = beingEdited;
            this.raceID = raceID;
            InitializeComponent();
        }

        /// <summary>
        /// Adds a new race using query. Will close the original Edit Races window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            //For more information: https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql/linq/how-to-connect-to-a-database
            DnDataSetDataContext db = new DnDataSetDataContext();
            //Table<Race> Races = db.GetTable<Race>();
            if (txtName.Text == "")
            {
                MessageBox.Show("Invalid name");
            }
            else
            {
                EditRaces n = new EditRaces(fontSize);
                if (beingEdited == false)
                {
                    Race race = new Race
                    {
                        Name = txtName.Text,
                        Strength = Convert.ToInt32(txtStr.Text),
                        Dexterity = Convert.ToInt32(txtDex.Text),
                        Constitution = Convert.ToInt32(txtCon.Text),
                        Intelligence = Convert.ToInt32(txtInt.Text),
                        Wisdom = Convert.ToInt32(txtWis.Text), 
                        Charisma = Convert.ToInt32(txtCha.Text)
                    };

                    db.Races.InsertOnSubmit(race);
                    db.SubmitChanges();
                    
                    n.Show();

                    this.Close();
                }
                else
                {
                    
                    var query =
                        from race in db.Races
                        where race.Id == raceID
                        select race;

                    foreach (Race races in query)
                    {
                        races.Name = txtName.Text;
                        races.Strength = Convert.ToInt32(txtStr.Text);
                        races.Dexterity = Convert.ToInt32(txtDex.Text);
                        races.Constitution = Convert.ToInt32(txtCon.Text);
                        races.Intelligence = Convert.ToInt32(txtInt.Text);
                        races.Wisdom = Convert.ToInt32(txtWis.Text);
                        races.Charisma = Convert.ToInt32(txtCha.Text);
                    }
                    try
                    {
                        db.SubmitChanges();
                        this.Close();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show($"Error: {exc}");
                    }
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #region get/set

        public string ButtonText
        {
            get
            {
                return this.btnAccept.Text;
            }
            set
            {
                this.btnAccept.Text = value;
            }
        }
        public string RaceName
        {
            get
            {
                return this.txtName.Text;
            }
            set
            {
                this.txtName.Text = value;
            }
        }
        public string Str
        {
            get
            {
                return this.txtStr.Text;
            }
            set
            {
                this.txtStr.Text = value;
            }
        }
        public string Dex
        {
            get
            {
                return this.txtDex.Text;
            }
            set
            {
                this.txtDex.Text = value;
            }
        }
        public string Con
        {
            get
            {
                return this.txtCon.Text;
            }
            set
            {
                this.txtCon.Text = value;
            }
        }
        public string Int
        {
            get
            {
                return this.txtInt.Text;
            }
            set
            {
                this.txtInt.Text = value;
            }
        }
        public string Wis
        {
            get
            {
                return this.txtWis.Text;
            }
            set
            {
                this.txtWis.Text = value;
            }
        }
        public string Cha
        {
            get
            {
                return this.txtCha.Text;
            }
            set
            {
                this.txtCha.Text = value;
            }
        }
        #endregion
    }
}
