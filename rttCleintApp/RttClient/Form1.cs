using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Service.Models;
using AddressDetails = RttClient.ClientService.AddressDetails;
using ClientDetail = RttClient.ClientService.ClientDetail;
using ContactDetails = RttClient.ClientService.ContactDetails;


namespace RttClient
{
    public partial class frmClient : Form
    {
        private IServiceHandler IserviceHandler { get; set; }
        private const string _successMsg = "Information saved successfully";
        private static RttLogger _rttLogger = new RttLogger();

        private Guid _ClientId;

        public DialogResult ShowInputDialog(out string inputReference, string message, string title, bool isPassword)
        {
            return InputBox.Show(message, title, isPassword, out inputReference);
        }

        public static class InputBox
        {
            /// <summary>
            ///     Displays a dialog with a prompt and textbox where the user can enter information
            /// </summary>
            /// <param name="title">Dialog title</param>
            /// <param name="promptText">Dialog prompt</param>
            /// <param name="value">Sets the initial value and returns the result</param>
            /// <returns>Dialog result</returns>
            public static DialogResult Show(string promptText, string title, bool isPassword, out string value)
            {
                value = "";
                var form = new Form();
                var label = new Label();
                var textBox = new TextBox();
                var buttonOk = new Button();
                var buttonCancel = new Button();

                form.Text = title;
                label.Text = promptText;
                textBox.Text = value;

                buttonOk.Text = "OK";
                buttonCancel.Text = "Cancel";
                buttonOk.DialogResult = DialogResult.OK;
                buttonCancel.DialogResult = DialogResult.Cancel;

                label.SetBounds(9, 20, 372, 13);
                textBox.SetBounds(12, 36, 372, 20);
                buttonOk.SetBounds(228, 72, 75, 23);
                buttonCancel.SetBounds(309, 72, 75, 23);

                label.AutoSize = true;
                textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
                buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

                form.ClientSize = new Size(396, 107);
                form.Controls.AddRange(new Control[] {label, textBox, buttonOk, buttonCancel});
                form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.MinimizeBox = false;
                form.MaximizeBox = false;
                form.AcceptButton = buttonOk;
                form.CancelButton = buttonCancel;
                if (isPassword)
                    textBox.PasswordChar = '*';

                var dialogResult = form.ShowDialog();
                value = textBox.Text;
                return dialogResult;
            }
        }

        public frmClient()
        {
            InitializeComponent();
            tcClient.TabIndex = 0;
            GetAllClients();
        }

        public void GetAllClients()
        {
            try
            {
                IserviceHandler = new ServiceHandler();
                var clients = IserviceHandler.GetAllClients();
                dgvClients.DataSource = clients;
                tcClient.SelectedIndex = 1;

            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                IserviceHandler = new ServiceHandler();
                if (validateAddress() && validateContactDetails() && validateClientDetails())
                {
                    ClientDetail clientDetails = new ClientDetail
                    {
                        IdNumber = long.Parse(txtIdNumber.Text),
                        Name = txtName.Text,
                        Gender = cmbGender.Text,
                        Surname = txtSurname.Text,
                        Id = Guid.NewGuid()

                    };
                    var saved = IserviceHandler.SaveClientData(clientDetails);
                    if (saved)
                    {
                        _ClientId = clientDetails.Id;
                        SaveAddressDetails(clientDetails.Id);
                        SaveContactDetails(clientDetails.Id);


                    }
                }
                else
                {
                    MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }
            
        }

        public void SaveAddressDetails(Guid clientId)
        {
            try
            {
                IserviceHandler = new ServiceHandler();
                AddressDetails details = new AddressDetails
                {
                    StreetAddressLine1 = txtStreetAddress.Text,
                    PostalCode = txtPostalCode.Text,
                    City = txtCity.Text,
                    Province = cmbProvince.Text,
                    ClientId = clientId,
                    StreetAddressLine2 = txtSurburb.Text
                };
                var savedAddressDetails = IserviceHandler.SaveAddressData(details);
                bindGrid();
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }
        }



        public void SaveContactDetails(Guid clientId)
        {
            try
            {
                IserviceHandler = new ServiceHandler();
                ContactDetails details = new ContactDetails
                {
                    ClientId = clientId,
                    Number = txtNumber.Text,
                    Type = cmbType.Text
                };
                var savedContactDetails = IserviceHandler.SaveContactData(details);
                bindGrid();

            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }
        }

        public void bindGrid()
        {
            var result = IserviceHandler.GetAllContactDetails(_ClientId.ToString());
            dgvContactDetails.DataSource = result;
            var result1 = IserviceHandler.GetAllAddressDetails(_ClientId.ToString());
            dgvAddresses.DataSource = result1;

        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            try
            {
                if (_ClientId != Guid.Empty && validateAddress())
                {
                    SaveAddressDetails(_ClientId);
                }
                else
                {
                    MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }
           

        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            try
            {
                if (_ClientId != Guid.Empty && validateContactDetails())
                {
                    SaveContactDetails(_ClientId);
                }
                else
                {
                    MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }

        }

        private void dgvClients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Proceed to view Client details?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int rowindex = dgvClients.CurrentCell.RowIndex;
                    int columnindex = dgvClients.CurrentCell.ColumnIndex;

                    _ClientId = Guid.Parse(dgvClients.Rows[rowindex].Cells[0].Value.ToString());
                    tcClient.SelectedIndex = 0;
                    bindGrid();
                    txtName.Text = dgvClients.Rows[rowindex].Cells[1].Value.ToString();
                    txtSurname.Text = dgvClients.Rows[rowindex].Cells[3].Value.ToString();
                    cmbGender.Text = dgvClients.Rows[rowindex].Cells[2].Value.ToString();
                    txtIdNumber.Text = dgvClients.Rows[rowindex].Cells[4].Value.ToString();
                    btnAddress.Visible = true;
                    btnAddContact.Visible = true;

                }
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }
            
        }

        public bool validateContactDetails()
        {
            if (!string.IsNullOrEmpty(txtNumber.Text) && !string.IsNullOrEmpty(cmbType.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validateAddress()
        {
            if (!string.IsNullOrEmpty(txtPostalCode.Text) && !string.IsNullOrEmpty(txtStreetAddress.Text) &&
                !string.IsNullOrEmpty(txtSurburb.Text) &&
                !string.IsNullOrEmpty(txtCity.Text) && !string.IsNullOrEmpty(cmbProvince.Text))
                return true;
            else return false;
        }

        public bool validateClientDetails()
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtSurname.Text) &&
                !string.IsNullOrEmpty(cmbGender.Text) && !string.IsNullOrEmpty(txtIdNumber.Text))
                return false;
            else return true;
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtIdNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbClient_Enter(object sender, EventArgs e)
        {
            if (_ClientId == Guid.Empty)
            {
                btnAddress.Visible = false;
                btnAddContact.Visible = false;
                txtName.Clear();
                txtSurname.Clear();
                cmbGender.Text = "";
                txtIdNumber.Clear();
                dgvAddresses.DataSource = null;
                dgvContactDetails.DataSource = null;
               
            }
        }

        private void tbClient_Leave(object sender, EventArgs e)
        {
            _ClientId = Guid.Empty;
        }
    }
}

