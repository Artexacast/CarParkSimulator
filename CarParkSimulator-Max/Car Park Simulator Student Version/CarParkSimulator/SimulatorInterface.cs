using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarParkSimulator
{
    public partial class SimulatorInterface : Form
    {
        // Attributes ///        
        private TicketMachine ticketMachine;
        private ActiveTickets activeTickets;
        private TicketValidator ticketValidator;
        private Barrier entryBarrier;
        private Barrier exitBarrier;
        private FullSign fullSign;
        private CarPark carPark;
        private EntrySensor entrySensor;
        private ExitSensor exitSensor;
        /////////////////


        // Constructor //
        public SimulatorInterface()
        {
            InitializeComponent();
        }
        /////////////////


        // Operations ///
        private void ResetSystem(object sender, EventArgs e)
        {
            // STUDENTS:
            ///// Class contructors are not defined so there will be errors
            ///// This code is correct for the basic version though
            activeTickets = new ActiveTickets();
            ticketMachine = new TicketMachine(activeTickets);
            ticketValidator = new TicketValidator(activeTickets);
            entryBarrier = new Barrier();
            exitBarrier = new Barrier();
            fullSign = new FullSign();
            carPark = new CarPark(ticketMachine, ticketValidator, fullSign, entryBarrier, exitBarrier);
            entrySensor = new EntrySensor(carPark);
            exitSensor = new ExitSensor(carPark);

            ticketMachine.AssignCarPark(carPark);
            ticketValidator.AssignCarPark(carPark);

            /////////////////////////////////////////

            btnCarArrivesAtEntrance.Visible = true;
            btnDriverPressesForTicket.Visible = false;
            btnCarEntersCarPark.Visible = false;
            btnCarArrivesAtExit.Visible = false;
            btnDriverEntersTicket.Visible = false;
            btnCarExitsCarPark.Visible = false;

            UpdateDisplay();
        }

        private void CarArrivesAtEntrance(object sender, EventArgs e)
        {
            entrySensor.carDetected();
            UpdateDisplay();
            btnDriverPressesForTicket.Show();
            btnCarArrivesAtEntrance.Hide();
        }

        private void DriverPressesForTicket(object sender, EventArgs e)
        {
            ticketMachine.printTicket();
            UpdateDisplay();
            btnCarEntersCarPark.Show();
            btnDriverPressesForTicket.Hide();
        }

        private void CarEntersCarPark(object sender, EventArgs e)
        {
            entrySensor.carLeftSensor();
            UpdateDisplay();

            if (carPark.getCurrentSpaces() != 0)
            {
                btnCarArrivesAtExit.Show();
                btnPayForTicket.Show();
            }

            btnCarEntersCarPark.Hide();

            if (carPark.getCurrentSpaces() != 5)
            {
                btnCarArrivesAtEntrance.Show();
            }
        }

        private void btnPayForTicket_Click(object sender, EventArgs e)
        {
            if (activeTickets.GetTickets().Count != 0)
            {
                int lastTicket = activeTickets.GetTickets().Count - 1;
                activeTickets.GetTickets()[lastTicket].setPaid(true);
            }
           //sets paid on ticket to true

            if (carPark.getCurrentSpaces() == 0)
            {
                btnPayForTicket.Hide();
            }

            if (btnCarArrivesAtExit.Visible == false)
            {
                btnCarArrivesAtExit.Show();
            }

            lblPayReminder.Hide();

        }

        private void CarArrivesAtExit(object sender, EventArgs e)
        {
            exitSensor.carDetected();
            UpdateDisplay();
            btnDriverEntersTicket.Show();

            btnCarArrivesAtExit.Hide();
        }

        private void DriverEntersTicket(object sender, EventArgs e)
        {

            UpdateDisplay();

            int lastTicket = 0;

            if (activeTickets.GetTickets().Count != 0)
            {
                lastTicket = activeTickets.GetTickets().Count - 1;

                if (activeTickets.GetTickets()[lastTicket].isPaid() == true)
                {
                    btnCarExitsCarPark.Show();
                }
            }
            
            
            ticketValidator.ticketEntered();

            btnDriverEntersTicket.Hide();
        }

        private void CarExitsCarPark(object sender, EventArgs e)
        {
            exitSensor.carLeftSensor();
            UpdateDisplay();
            btnCarExitsCarPark.Hide();

            if (carPark.getCurrentSpaces() != 0)
            {
                btnCarArrivesAtExit.Show();
            }

            if (carPark.getCurrentSpaces() != 5)
            {
                btnCarArrivesAtEntrance.Show();
            }
        }

        private void UpdateDisplay()
        {
            lblEntryBarrier.Text = Convert.ToString(entryBarrier.IsLifted());
            lblExitBarrier.Text = Convert.ToString(exitBarrier.IsLifted());
            lblEntrySensor.Text = Convert.ToString(entrySensor.isCarOnSensor());
            lblExitSensor.Text = Convert.ToString(exitSensor.isCarOnSensor());
            lblFullSign.Text = Convert.ToString(fullSign.isLit());
            lblSpaces.Text = Convert.ToString(carPark.getCurrentSpaces());
            lblTicketMachine.Text = Convert.ToString(ticketMachine.getMessage());
            lblTicketValidator.Text = Convert.ToString(ticketValidator.getMessage());

            if (activeTickets.GetTickets().Count != 0)
            {
                lstActiveTickets.Items.Clear();

                for (int i = 0; i < activeTickets.GetTickets().Count; i++)
                {
                    lstActiveTickets.Items.Add(activeTickets.GetTickets()[i].getName());
                }

            }
            else
            {
                lstActiveTickets.Items.Clear();
            }

            if (activeTickets.GetTickets().Count != 0)
            {
                int lastTicket = activeTickets.GetTickets().Count - 1;
                if (activeTickets.GetTickets()[lastTicket].isPaid() == false)
                {
                    lblPayReminder.Show();
                }
            }
        }




        private void lblTicketValidator_Click(object sender, EventArgs e)
        {

        }

        private void lstActiveTickets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



    }
}
