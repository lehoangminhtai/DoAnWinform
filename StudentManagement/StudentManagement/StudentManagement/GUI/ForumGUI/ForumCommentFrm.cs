using StudentManagement.DAO;
using StudentManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagement.GUI.ForumGUI
{
    public partial class ForumCommentFrm : Form
    {
        public int id_Forum {  get; set; }
        public string id_User {  get; set; }
        public int id_Comment { get; set; }
        public string nameCourse {  get; set; }
        public string question {  get; set; }

        CommentDAO commentDAO= new CommentDAO();
        XJDBC db = new XJDBC();
        public string condition = $""; 
        public string sql = "select ct.MaBL, ct.Noidung, ct.NgayDang, ct.MaNguoiDang, ct.HinhAnh from ChiTietDienDan ct where ";

        PictureBox pictureBox = new PictureBox() ;
        public ForumCommentFrm()
        {
            InitializeComponent();
        }

        private void ForumCommentFrm_Load(object sender, EventArgs e)
        {
            lblNotice.Visible = false;
            lblImageName.Text = "";
            txtQuestion.Text = question;
            lblCourseName.Text = nameCourse;
            fillData();
        }

        private void fillData()
        {
            fillListComment();
        }
        private void fillListComment()
        {
            condition = $"ct.MaDD = '{id_Forum}'";
            SqlCommand cmd = new SqlCommand(sql + condition);

            showListForum(cmd);
        }

        private void showListForum(SqlCommand cmd)
        {
            int panelY = 10;
            int x_location = 40;
            panelComment.Controls.Clear();
            List<COMMENT> list = commentDAO.getListComment(cmd);
            foreach (var c in list)
            {
                Panel panelCmt = new Panel();
                panelCmt.BorderStyle = BorderStyle.None;
                panelCmt.Location = new Point(0, panelY);
                panelCmt.Size = new Size(600, 100);
                panelCmt.Margin = new Padding(10);
                panelCmt.BackColor = Color.Transparent;

                (MemoryStream picI, string fullname) = setAvatar(c.id_user);

                PictureBox pic = new PictureBox();
                pic.Location = new Point(x_location-40, 10);
                pic.Size= new Size(35, 35);
                pic.Image = Image.FromStream(picI);
                pic.SizeMode = PictureBoxSizeMode.Zoom;

                int location_y_cmt = 68;
                string content = c.comment;
                Label labelCmt = new Label();
                labelCmt.Location = new Point(x_location, location_y_cmt);
                labelCmt.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                labelCmt.ForeColor = Color.DarkCyan;
                labelCmt.AutoSize = true;

                if (content.Length >= 80)
                {
                    // Tách content thành các phần nhỏ có độ dài tối đa là 70 ký tự
                    string[] lines = SplitByLength(content, 80);

                    // Gắn từng dòng vào labelCmt
                    for (int i = 0; i < lines.Length; i++)
                    {
                        Label lineLabel = new Label();
                        lineLabel.Text = lines[i];
                        lineLabel.Location = new Point(x_location, location_y_cmt + (i * 20)); // 20 là khoảng cách giữa các dòng
                        lineLabel.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                        lineLabel.ForeColor = Color.DarkCyan;
                        lineLabel.AutoSize = true;

                        panelCmt.Controls.Add(lineLabel);
                        panelCmt.Height += 20;
                        location_y_cmt += 20;
                    }
                }
                else
                {
                    // Nếu content không quá 70 ký tự, hiển thị nó trong một dòng
                    labelCmt.Text = content;
                    location_y_cmt += 20;


                }

                if (c.image != null)
                {
                    PictureBox imageCmt = new PictureBox();
                    imageCmt.Location = new Point(x_location, location_y_cmt);
                    imageCmt.Size = new Size(100, 80);
                    imageCmt.Image = Image.FromStream(c.image);
                    imageCmt.SizeMode = PictureBoxSizeMode.Zoom;
                    panelCmt.Height += 80;
                    panelCmt.Controls.Add(imageCmt);

                    imageCmt.Click += (clickImg, eventArgs) =>
                    {
                        ShowImageCmt frm = new ShowImageCmt();
                        frm.pic=c.image;
                        frm.ShowDialog();
                    };
                }
                

                Label labelUserCreate = new Label();
                labelUserCreate.Text =  fullname;
                labelUserCreate.Location = new Point(x_location, 10);
                labelUserCreate.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
                labelUserCreate.AutoSize = true;


                Label labelTime = new Label();
                labelTime.Text =  c.date.ToString("dd/MM/yyyy hh:mm");
                labelTime.Location = new Point(x_location, 43);
                labelTime.AutoSize = true;
                labelTime.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Italic);

                
                Button btnDelete = new Button();
                btnDelete.BackgroundImage = Image.FromFile("Image/delete.png");
                btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
                btnDelete.Location = new Point(550, 10);
                btnDelete.Size = new Size(45, 30);
                btnDelete.Tag = c.id_comment;

                btnDelete.Click += (clickButton, eventArgs) =>
                {
                    Dictionary<string, object> dic = new Dictionary<string, object>
                    {
                        {"MaBL",c.id_comment}
                    };
                    DialogResult res = MessageBox.Show("Bạn có chắc muốn xoá bình luận này?", "Bình luận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        if (commentDAO.deleteComment("ChiTietDienDan", dic))
                        {
                            fillListComment();
                        }
                    }
                };
                if (c.id_user.Trim() == id_User.Trim())
                {
                    panelCmt.Controls.Add(btnDelete);
                }
                panelCmt.Controls.Add(labelCmt);
                panelCmt.Controls.Add(labelUserCreate);
                panelCmt.Controls.Add(labelTime);
                panelCmt.Controls.Add(pic);

                panelY += panelCmt.Height + 10;

                panelComment.Controls.Add(panelCmt);


            }
        }

        private string[] SplitByLength(string input, int maxLength)
        {
            // Tách chuỗi thành các phần nhỏ có độ dài tối đa là maxLength
            int splitLength = (int)Math.Ceiling((double)input.Length / maxLength);
            string[] substrings = new string[splitLength];
            for (int i = 0; i < splitLength; ++i)
            {
                int start = i * maxLength;
                int length = Math.Min(maxLength, input.Length - start);
                substrings[i] = input.Substring(start, length);
            }
            return substrings;
        }

        private (MemoryStream pic ,string name) setAvatar(string id_user)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT 
                                                    CASE 
                                                        WHEN tk.Quyen = 1 THEN hs.HinhAnh
                                                        WHEN tk.Quyen = 2 THEN gv.HinhAnh
                                                    END AS HinhAnh,
                                                    CASE 
                                                        WHEN tk.Quyen = 1 THEN CONCAT(hs.Ho,' ',hs.Ten)
                                                        WHEN tk.Quyen = 2 THEN CONCAT(gv.Ho,' ',gv.Ten)
                                                    END AS Ten
                                                FROM 
                                                    TaiKhoan tk
                                                LEFT JOIN 
                                                    HocSinh hs ON tk.MaNguoiDung = hs.MaSV
                                                LEFT JOIN 
                                                    GiangVien gv ON tk.MaNguoiDung = gv.MaGV
                                                WHERE 
                                                    tk.MaNguoiDung = @id;
                                                 ", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id_user;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            byte[] pic;
            if (table.Rows[0]["HinhAnh"] != DBNull.Value && table.Rows[0]["Ten"] != DBNull.Value)
            {
                pic = (byte[])table.Rows[0]["HinhAnh"];
                MemoryStream picture = new MemoryStream(pic);

                string ten = (string)table.Rows[0]["Ten"];
                return (picture,ten);
            }
            else

                return (null, null);

        }


        private void btnComment_Click(object sender, EventArgs e)
        {
            if (insert())
            {
               
                txtComment.Text = "";
                lblImageName.Text = "";
                pictureBox.Image = null;
                fillListComment();
            }
        }
        private bool insert()
        {
            try
            {
                string tablename = "ChiTietDienDan";
               
                DateTime currentDate = DateTime.Now;
                string content = txtComment.Text.Trim();
                if (content != "")
                {
                    if (content.Length <= 2999)
                    {   if (pictureBox.Image == null && lblImageName.Text == "")
                        {


                            Dictionary<string, object> data = new Dictionary<string, object>
                        {
                        {"MaDD",id_Forum},{"Noidung",content }, {"MaNguoiDang",id_User}, {"NgayDang",currentDate }
                    };
                            return commentDAO.insertComment(tablename, data);
                        }
                        else
                        {

                            MemoryStream pic = new MemoryStream();
                            if (pictureBox.Image != null)
                            {
                                // Tạo một bản sao của hình ảnh từ picBoxAnhSV.Image
                                using (MemoryStream tempStream = new MemoryStream())
                                {
                                    pictureBox.Image.Save(tempStream, pictureBox.Image.RawFormat);
                                    tempStream.Position = 0;

                                    // Copy dữ liệu từ bản sao vào MemoryStream
                                    tempStream.CopyTo(pic);
                                }
                            }
                            Dictionary<string, object> data = new Dictionary<string, object>
                        {
                        {"MaDD",id_Forum},{"Noidung",content }, {"MaNguoiDang",id_User}, {"NgayDang",currentDate },{"HinhAnh",pic.ToArray()}
                    };
                            return commentDAO.insertComment(tablename, data);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập bình luận có độ dài không quá 3000 ký tự!!", "Bình luận", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    lblNotice.Visible = true;
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                try {
                    string nameImage = System.IO.Path.GetFileName(opf.FileName);
                    lblImageName.Text = nameImage;
                    pictureBox.Image = Image.FromFile(opf.FileName);
                }
                catch { }

            }
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            lblNotice.Visible=false;
        }
    }
}
