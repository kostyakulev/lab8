using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

//Пространство имен, используемое для определения культуры
//приложения и операционной системы
using System.Globalization;
//Пространство, используемое для работы с файлами ресурсов .resx,
//такими как ClosingText.en-US.resx, ClosingText.ru-RU.resx.
using System.Resources;
//Пространство для работы со сборками, более подробно о них см главу 9.
using System.Reflection;
using System.Threading;

namespace TextEditor
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtBox;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuOpen;
		private System.Windows.Forms.MenuItem mnuSave;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		public bool IsSaved = false;
		private System.Windows.Forms.MenuItem mnuLanguage;
		private System.Windows.Forms.MenuItem mnuEnglish;
		private System.Windows.Forms.MenuItem mnuRussian;
		public string fileName;
		//Переменная выбора, необходимая для определения культуры 
		public string CultureDefine;
		//Переменная для хранения английской культуры
		private  string EnglishCulture;
		//Переменная для русской культуры.
		private  string RussianCulture;
		//Создаем экземпляр resourceManager класса ResourceManager
		 ResourceManager resourceManager;

		public Form1()
		{
			
			InitializeComponent();
			//Инициализируем переменные
			EnglishCulture = "en-US";
			RussianCulture = "ru-RU";

			// Перменной CultureDefine присваиваем значение культуры, установленной на компьютере, 
			//используя свойство класса ResourceManager
			CultureDefine = CultureInfo.InstalledUICulture.ToString();

			// Создаем новый объект resourceManager, извлекающий из сборки 
			//текстовую переменную ClosingText
			resourceManager = new ResourceManager("TextEditor.ClosingText", Assembly.GetExecutingAssembly());
			
		}


		public Form1(string FormCulture)
		{
		
			InitializeComponent();
			EnglishCulture = "en-US";
			RussianCulture = "ru-RU";

			//В качестве культуры устанавливаем значение CultureDefine
			CultureDefine = FormCulture;

			// Создаем новый объект resourceManager, извлекающий из сборки 
			//текстовую переменную ClosingText
			resourceManager = new ResourceManager("TextEditor.ClosingText", Assembly.GetExecutingAssembly());
	
		}


		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.txtBox = new System.Windows.Forms.TextBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.mnuFile = new System.Windows.Forms.MenuItem();
			this.mnuOpen = new System.Windows.Forms.MenuItem();
			this.mnuSave = new System.Windows.Forms.MenuItem();
			this.mnuLanguage = new System.Windows.Forms.MenuItem();
			this.mnuEnglish = new System.Windows.Forms.MenuItem();
			this.mnuRussian = new System.Windows.Forms.MenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// txtBox
			// 
			this.txtBox.AccessibleDescription = resources.GetString("txtBox.AccessibleDescription");
			this.txtBox.AccessibleName = resources.GetString("txtBox.AccessibleName");
			this.txtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("txtBox.Anchor")));
			this.txtBox.AutoSize = ((bool)(resources.GetObject("txtBox.AutoSize")));
			this.txtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBox.BackgroundImage")));
			this.txtBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("txtBox.Dock")));
			this.txtBox.Enabled = ((bool)(resources.GetObject("txtBox.Enabled")));
			this.txtBox.Font = ((System.Drawing.Font)(resources.GetObject("txtBox.Font")));
			this.txtBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("txtBox.ImeMode")));
			this.txtBox.Location = ((System.Drawing.Point)(resources.GetObject("txtBox.Location")));
			this.txtBox.MaxLength = ((int)(resources.GetObject("txtBox.MaxLength")));
			this.txtBox.Multiline = ((bool)(resources.GetObject("txtBox.Multiline")));
			this.txtBox.Name = "txtBox";
			this.txtBox.PasswordChar = ((char)(resources.GetObject("txtBox.PasswordChar")));
			this.txtBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("txtBox.RightToLeft")));
			this.txtBox.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("txtBox.ScrollBars")));
			this.txtBox.Size = ((System.Drawing.Size)(resources.GetObject("txtBox.Size")));
			this.txtBox.TabIndex = ((int)(resources.GetObject("txtBox.TabIndex")));
			this.txtBox.Text = resources.GetString("txtBox.Text");
			this.txtBox.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("txtBox.TextAlign")));
			this.txtBox.Visible = ((bool)(resources.GetObject("txtBox.Visible")));
			this.txtBox.WordWrap = ((bool)(resources.GetObject("txtBox.WordWrap")));
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuFile,
																					  this.mnuLanguage});
			this.mainMenu1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("mainMenu1.RightToLeft")));
			// 
			// mnuFile
			// 
			this.mnuFile.Enabled = ((bool)(resources.GetObject("mnuFile.Enabled")));
			this.mnuFile.Index = 0;
			this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuOpen,
																					this.mnuSave});
			this.mnuFile.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mnuFile.Shortcut")));
			this.mnuFile.ShowShortcut = ((bool)(resources.GetObject("mnuFile.ShowShortcut")));
			this.mnuFile.Text = resources.GetString("mnuFile.Text");
			this.mnuFile.Visible = ((bool)(resources.GetObject("mnuFile.Visible")));
			// 
			// mnuOpen
			// 
			this.mnuOpen.Enabled = ((bool)(resources.GetObject("mnuOpen.Enabled")));
			this.mnuOpen.Index = 0;
			this.mnuOpen.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mnuOpen.Shortcut")));
			this.mnuOpen.ShowShortcut = ((bool)(resources.GetObject("mnuOpen.ShowShortcut")));
			this.mnuOpen.Text = resources.GetString("mnuOpen.Text");
			this.mnuOpen.Visible = ((bool)(resources.GetObject("mnuOpen.Visible")));
			this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
			// 
			// mnuSave
			// 
			this.mnuSave.Enabled = ((bool)(resources.GetObject("mnuSave.Enabled")));
			this.mnuSave.Index = 1;
			this.mnuSave.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mnuSave.Shortcut")));
			this.mnuSave.ShowShortcut = ((bool)(resources.GetObject("mnuSave.ShowShortcut")));
			this.mnuSave.Text = resources.GetString("mnuSave.Text");
			this.mnuSave.Visible = ((bool)(resources.GetObject("mnuSave.Visible")));
			this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
			// 
			// mnuLanguage
			// 
			this.mnuLanguage.Enabled = ((bool)(resources.GetObject("mnuLanguage.Enabled")));
			this.mnuLanguage.Index = 1;
			this.mnuLanguage.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.mnuEnglish,
																						this.mnuRussian});
			this.mnuLanguage.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mnuLanguage.Shortcut")));
			this.mnuLanguage.ShowShortcut = ((bool)(resources.GetObject("mnuLanguage.ShowShortcut")));
			this.mnuLanguage.Text = resources.GetString("mnuLanguage.Text");
			this.mnuLanguage.Visible = ((bool)(resources.GetObject("mnuLanguage.Visible")));
			// 
			// mnuEnglish
			// 
			this.mnuEnglish.Enabled = ((bool)(resources.GetObject("mnuEnglish.Enabled")));
			this.mnuEnglish.Index = 0;
			this.mnuEnglish.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mnuEnglish.Shortcut")));
			this.mnuEnglish.ShowShortcut = ((bool)(resources.GetObject("mnuEnglish.ShowShortcut")));
			this.mnuEnglish.Text = resources.GetString("mnuEnglish.Text");
			this.mnuEnglish.Visible = ((bool)(resources.GetObject("mnuEnglish.Visible")));
			this.mnuEnglish.Click += new System.EventHandler(this.mnuEnglish_Click);
			// 
			// mnuRussian
			// 
			this.mnuRussian.Enabled = ((bool)(resources.GetObject("mnuRussian.Enabled")));
			this.mnuRussian.Index = 1;
			this.mnuRussian.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mnuRussian.Shortcut")));
			this.mnuRussian.ShowShortcut = ((bool)(resources.GetObject("mnuRussian.ShowShortcut")));
			this.mnuRussian.Text = resources.GetString("mnuRussian.Text");
			this.mnuRussian.Visible = ((bool)(resources.GetObject("mnuRussian.Visible")));
			this.mnuRussian.Click += new System.EventHandler(this.mnuRussian_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "Текстовые файлы";
			this.openFileDialog1.Filter = resources.GetString("openFileDialog1.Filter");
			this.openFileDialog1.Title = resources.GetString("openFileDialog1.Title");
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "Текстовые файлы";
			this.saveFileDialog1.Filter = resources.GetString("saveFileDialog1.Filter");
			this.saveFileDialog1.Title = resources.GetString("saveFileDialog1.Title");
			// 
			// Form1
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.txtBox);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.Menu = this.mainMenu1;
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "Form1";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
			this.Closed += new System.EventHandler(this.Form1_Closed);
			this.ResumeLayout(false);

		}
		#endregion

	
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void mnuOpen_Click(object sender, System.EventArgs e)
		{
			//Показываем диалог выбора файла
			openFileDialog1.ShowDialog() ;
			// Переменной fileName присваиваем имя открываемого файла
			string fileName = openFileDialog1.FileName;
			//Создаем поток fs и открываем файл для чтения.
			FileStream filestream= File.Open(fileName, FileMode.Open, FileAccess.Read);
			//Проверяем,  открыт ли поток,  и если открыт, выполняем условие
			if(filestream != null)
			{
				//Создаем объект streamreader и связываем его с потоком filestream
				StreamReader streamreader = new StreamReader(filestream);
				//Считываем весь файл и записываем его в TextBox
				txtBox.Text = streamreader.ReadToEnd();
				//Закрываем поток.
				filestream.Close();
			}
		}

		private void mnuSave_Click(object sender, System.EventArgs e)
		{
			this.Save( fileName, e);
		}
	


		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			//Если переменная IsSaved имеет значение true, т. е документ новый документ 
			//был сохранен (Save As) или в открытом документе были сохранены изменения (Save) то выполняется условие
			if(IsSaved ==true)
				//Появляется диалоговое окно, предлагающее сохранить документ.
				if	(MessageBox.Show(resourceManager.GetString("MessageText"), 
					resourceManager.GetString("ItemText"), MessageBoxButtons.YesNo, 
					MessageBoxIcon.Question) == DialogResult.Yes)
					//Если была нажата  кнопка Yes, вызываем метод Save
				{
					this.Save( fileName, e);
				}	
		}	
		public void Save(object sender, System.EventArgs e)
		{
			//Показываем диалог выбора файла
			saveFileDialog1.ShowDialog();
			// В качестве имени сохраняемого файла устанавливаем переменную fileName
			 fileName=saveFileDialog1.FileName;
			//Создаем поток fs и открываем файл для записи.
			FileStream filestream = File.Open(fileName, FileMode.Create, FileAccess.Write);
			//Проверяем,  открыт ли поток,  и если открыт, выполняем условие
			if(filestream != null)
			{
				//Создаем объект streamwriter и связываем его с потоком filestream
				StreamWriter streamwriter = new StreamWriter(filestream);
				//Записываем данные из TextBox в файл
				streamwriter.Write(txtBox.Text);
				//Переносим данные из потока в файл
				streamwriter.Flush();
				//Закрываем поток
				filestream.Close();
				IsSaved = true;
			}
		}

		private void mnuEnglish_Click(object sender, System.EventArgs e)
		{
			//Устанавливаем английскую культуру в качестве выбранной.
			CultureDefine = EnglishCulture;
			// Устанавливаем выбранную культуру в качестве культуры  пользовательского интерфейса 
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(CultureDefine, false);
			// Устанавливаем в качестве текущей культуры выбранную
			Thread.CurrentThread.CurrentCulture = new CultureInfo(CultureDefine, false);
			//Создаем новый экземпляр frm формы Form1:
			Form1 frm = new Form1(CultureDefine);
			//Скрываем текущий экземпляр
			this.Hide();
			//Вызываем новый экземпляр
			frm.Show();

		}

		private void mnuRussian_Click(object sender, System.EventArgs e)
		{
			CultureDefine = RussianCulture;
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(CultureDefine, false);
			Thread.CurrentThread.CurrentCulture = new CultureInfo(CultureDefine, false);
			Form1 frm = new Form1(CultureDefine);
			this.Hide();
			frm.Show();
		}

		private void Form1_Closed(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		
}
}
	

