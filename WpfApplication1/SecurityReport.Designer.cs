namespace WpfApplication1
{
    partial class SecurityReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecurityReport));
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Group group2 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.SecurityData = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.payeeCaptionTextBox = new Telerik.Reporting.TextBox();
            this.beneficiaryCaptionTextBox = new Telerik.Reporting.TextBox();
            this.amountCaptionTextBox = new Telerik.Reporting.TextBox();
            this.schoolCaptionTextBox = new Telerik.Reporting.TextBox();
            this.statusCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.processedbyGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.processedbyGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.payeeDataTextBox = new Telerik.Reporting.TextBox();
            this.beneficiaryDataTextBox = new Telerik.Reporting.TextBox();
            this.amountDataTextBox = new Telerik.Reporting.TextBox();
            this.schoolDataTextBox = new Telerik.Reporting.TextBox();
            this.statusDataTextBox = new Telerik.Reporting.TextBox();
            this.dateDataTextBox = new Telerik.Reporting.TextBox();
            this.pictureBox1 = new Telerik.Reporting.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // SecurityData
            // 
            this.SecurityData.ConnectionString = "WpfApplication1.Properties.Settings.ConnectionString";
            this.SecurityData.Name = "SecurityData";
            this.SecurityData.SelectCommand = resources.GetString("SecurityData.SelectCommand");
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.textBox2,
            this.payeeCaptionTextBox,
            this.beneficiaryCaptionTextBox,
            this.amountCaptionTextBox,
            this.schoolCaptionTextBox,
            this.statusCaptionTextBox,
            this.dateCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox1.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox1.StyleName = "Caption";
            this.textBox1.Value = "Processed by";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.82552081346511841D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox2.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox2.StyleName = "Caption";
            this.textBox2.Value = "Transaction Id";
            // 
            // payeeCaptionTextBox
            // 
            this.payeeCaptionTextBox.CanGrow = true;
            this.payeeCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6302083730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.payeeCaptionTextBox.Name = "payeeCaptionTextBox";
            this.payeeCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.payeeCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.payeeCaptionTextBox.StyleName = "Caption";
            this.payeeCaptionTextBox.Value = "Payee";
            // 
            // beneficiaryCaptionTextBox
            // 
            this.beneficiaryCaptionTextBox.CanGrow = true;
            this.beneficiaryCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4348957538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.beneficiaryCaptionTextBox.Name = "beneficiaryCaptionTextBox";
            this.beneficiaryCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.beneficiaryCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.beneficiaryCaptionTextBox.StyleName = "Caption";
            this.beneficiaryCaptionTextBox.Value = "Beneficiary";
            // 
            // amountCaptionTextBox
            // 
            this.amountCaptionTextBox.CanGrow = true;
            this.amountCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.amountCaptionTextBox.Name = "amountCaptionTextBox";
            this.amountCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.amountCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.amountCaptionTextBox.StyleName = "Caption";
            this.amountCaptionTextBox.Value = "Amount";
            // 
            // schoolCaptionTextBox
            // 
            this.schoolCaptionTextBox.CanGrow = true;
            this.schoolCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0442709922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.schoolCaptionTextBox.Name = "schoolCaptionTextBox";
            this.schoolCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.schoolCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.schoolCaptionTextBox.StyleName = "Caption";
            this.schoolCaptionTextBox.Value = "School";
            // 
            // statusCaptionTextBox
            // 
            this.statusCaptionTextBox.CanGrow = true;
            this.statusCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.8489584922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.statusCaptionTextBox.Name = "statusCaptionTextBox";
            this.statusCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.statusCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.statusCaptionTextBox.StyleName = "Caption";
            this.statusCaptionTextBox.Value = "Status";
            // 
            // dateCaptionTextBox
            // 
            this.dateCaptionTextBox.CanGrow = true;
            this.dateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.6536459922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.dateCaptionTextBox.Name = "dateCaptionTextBox";
            this.dateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.dateCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dateCaptionTextBox.StyleName = "Caption";
            this.dateCaptionTextBox.Value = "Date";
            // 
            // processedbyGroupHeaderSection
            // 
            this.processedbyGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.processedbyGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox3});
            this.processedbyGroupHeaderSection.Name = "processedbyGroupHeaderSection";
            // 
            // processedbyGroupFooterSection
            // 
            this.processedbyGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.processedbyGroupFooterSection.Name = "processedbyGroupFooterSection";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox3.StyleName = "Data";
            this.textBox3.Value = "= Fields.[Processed by]";
            // 
            // pageHeader
            // 
            this.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.pageHeader.Name = "pageHeader";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.pageInfoTextBox});
            this.pageFooter.Name = "pageFooter";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.81875008344650269D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox,
            this.pictureBox1});
            this.reportHeader.Name = "reportHeader";
            this.reportHeader.Style.BackgroundColor = System.Drawing.Color.White;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1000000238418579D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.3583335876464844D), Telerik.Reporting.Drawing.Unit.Inch(0.787401556968689D));
            this.titleTextBox.Style.BackgroundColor = System.Drawing.Color.White;
            this.titleTextBox.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.titleTextBox.Style.LineColor = System.Drawing.Color.Black;
            this.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "AMANSIE WEST RURAL BANK GENERAL REPORT";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox4,
            this.payeeDataTextBox,
            this.beneficiaryDataTextBox,
            this.amountDataTextBox,
            this.schoolDataTextBox,
            this.statusDataTextBox,
            this.dateDataTextBox});
            this.detail.Name = "detail";
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.82552081346511841D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox4.StyleName = "Data";
            this.textBox4.Value = "= Fields.[Transaction Id]";
            // 
            // payeeDataTextBox
            // 
            this.payeeDataTextBox.CanGrow = true;
            this.payeeDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6302083730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.payeeDataTextBox.Name = "payeeDataTextBox";
            this.payeeDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.payeeDataTextBox.StyleName = "Data";
            this.payeeDataTextBox.Value = "= Fields.Payee";
            // 
            // beneficiaryDataTextBox
            // 
            this.beneficiaryDataTextBox.CanGrow = true;
            this.beneficiaryDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4348957538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.beneficiaryDataTextBox.Name = "beneficiaryDataTextBox";
            this.beneficiaryDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.beneficiaryDataTextBox.StyleName = "Data";
            this.beneficiaryDataTextBox.Value = "= Fields.Beneficiary";
            // 
            // amountDataTextBox
            // 
            this.amountDataTextBox.CanGrow = true;
            this.amountDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.amountDataTextBox.Name = "amountDataTextBox";
            this.amountDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.amountDataTextBox.StyleName = "Data";
            this.amountDataTextBox.Value = "= Fields.Amount";
            // 
            // schoolDataTextBox
            // 
            this.schoolDataTextBox.CanGrow = true;
            this.schoolDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0442709922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.schoolDataTextBox.Name = "schoolDataTextBox";
            this.schoolDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.schoolDataTextBox.StyleName = "Data";
            this.schoolDataTextBox.Value = "= Fields.School";
            // 
            // statusDataTextBox
            // 
            this.statusDataTextBox.CanGrow = true;
            this.statusDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.8489584922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.statusDataTextBox.Name = "statusDataTextBox";
            this.statusDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.statusDataTextBox.StyleName = "Data";
            this.statusDataTextBox.Value = "= Fields.Status";
            // 
            // dateDataTextBox
            // 
            this.dateDataTextBox.CanGrow = true;
            this.dateDataTextBox.Format = "{0:d}";
            this.dateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.6536459922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.dateDataTextBox.Name = "dateDataTextBox";
            this.dateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.dateDataTextBox.StyleName = "Data";
            this.dateDataTextBox.Value = "= Fields.Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(3.9339065551757812E-05D));
            this.pictureBox1.MimeType = "image/png";
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0790879726409912D), Telerik.Reporting.Drawing.Unit.Inch(0.78740149736404419D));
            this.pictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
            this.pictureBox1.Style.Color = System.Drawing.Color.Transparent;
            this.pictureBox1.Value = ((object)(resources.GetObject("pictureBox1.Value")));
            // 
            // SecurityReport
            // 
            this.DataSource = this.SecurityData;
            group1.GroupFooter = this.labelsGroupFooterSection;
            group1.GroupHeader = this.labelsGroupHeaderSection;
            group1.Name = "labelsGroup";
            group2.GroupFooter = this.processedbyGroupFooterSection;
            group2.GroupHeader = this.processedbyGroupHeaderSection;
            group2.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.[Processed by]"));
            group2.Name = "processedbyGroup";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1,
            group2});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.processedbyGroupHeaderSection,
            this.processedbyGroupFooterSection,
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.Name = "SecurityReport";
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule2.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            styleRule2.Style.Font.Name = "Tahoma";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule3.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            styleRule3.Style.Color = System.Drawing.Color.White;
            styleRule3.Style.Font.Name = "Tahoma";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule4.Style.Color = System.Drawing.Color.Black;
            styleRule4.Style.Font.Name = "Tahoma";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule5.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule5.Style.Color = System.Drawing.Color.Black;
            styleRule5.Style.Font.Name = "Tahoma";
            styleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4,
            styleRule5});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(6.4583334922790527D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource SecurityData;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox payeeCaptionTextBox;
        private Telerik.Reporting.TextBox beneficiaryCaptionTextBox;
        private Telerik.Reporting.TextBox amountCaptionTextBox;
        private Telerik.Reporting.TextBox schoolCaptionTextBox;
        private Telerik.Reporting.TextBox statusCaptionTextBox;
        private Telerik.Reporting.TextBox dateCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.GroupHeaderSection processedbyGroupHeaderSection;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.GroupFooterSection processedbyGroupFooterSection;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox payeeDataTextBox;
        private Telerik.Reporting.TextBox beneficiaryDataTextBox;
        private Telerik.Reporting.TextBox amountDataTextBox;
        private Telerik.Reporting.TextBox schoolDataTextBox;
        private Telerik.Reporting.TextBox statusDataTextBox;
        private Telerik.Reporting.TextBox dateDataTextBox;
        private Telerik.Reporting.PictureBox pictureBox1;
    }
}