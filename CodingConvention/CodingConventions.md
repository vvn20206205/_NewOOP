### Coding Conventions
	Code Convention được hiểu đơn giản là “quy ước viết code” - một nhóm các quy ước, quy tắc chung được áp dụng khi viết Code, giúp các khối code sẽ trở nên “sạch”, đẹp, dễ nhìn và dễ hiểu hơn.
	Các quy tắc viết code đóng vai trò vô cùng quan trọng đối với những dự án lớn, đòi hỏi nhiều lập trình viên.
•	Giúp cho công việc nhóm đạt hiệu quả cao
•	Tạo sự đồng bộ tốt, các thành viên dễ dàng hiểu code của nhau
•	Áp dụng được trong nhiều dự án, tái sử dụng code
•	Dễ dàng tìm và sửa lỗi, giảm thiểu tối đa các lỗi, đảm bảo hiệu năng.
	Những quy tắc chung khi viết code
•	Naming(Quy tắc đặt tên)
•	Style(Cách trình bày)
•	Solution(Cách giải quyết vấn đề)
	Ba quy tắc đặt tên phổ biến:
•	camelCase(cú pháp lạc đà)
•	PascalCase(cú pháp Pascal)
•	snake_case(cú pháp con rắn)

 
### Naming Conventions(Quy tắc đặt tên)
Qui tắc:
Yêu cầu	Ví dụ đúng	Ví dụ sai
Tên cần có ý nghĩa.	LayThongTin	ABC,xyz,…
Tên sử dụng tiếng Việt hết hoặc tiếng Anh hết.	LayThongTin hoặc GetInformation	LayThongTin và GetInformation
Phương thức bắt đầu bởi một động từ.	GetInformation	ComplexNumber
Lớp, thuộc tính, trường là danh từ.	ComplexNumber	GetInformation
 
Loại	Phong cách	Ví dụ đúng	Ví dụ sai
Class	Pascal	ComplexNumber	complexNumber, Complex_Number,…
Interface	Pascal
(Có tiền tố I)	IComplexNumber	complexNumber, IcomplexNumber, Icomplex_Number,…
Abstract class	Pascal
(Có tiền tố A)	AComplexNumber	complexNumber, AcomplexNumber, Acomplex_Number,…
Field	camelCase 	sinhVien	SinhVien,sinh_vien,…
Property, Method	Pascal	objComplexNumber.Real,
this.GetString()	objComplexNumber.real,
this.getString()
Lập trình hướng sự kiện (event)	Đối tượng + _ + sự kiện (giống default của Visual Studio)	btnSolve_Click	btnSolveClick, BtnSolveClick,…
CONST, CONFIG	snake_case và viết hoa	KHOA_HOC=65, HOURS_OF_A_DAY=24,…	khoa_hoc=65, HoursOfADay=24,…
Biến cục bộ (biến địa phương)	Pascal
(Có tiền tố _)	_SinhVien	SinhVien,sinh_vien,…
Biến trong Method	Pascal
(Có tiền tố i)	iSinhVien	SinhVien,sinh_vien,…
Biến tương tác , lựa chọn của người dùng 	camelCase
(Có tiền tố input)	inputSinhVien	SinhVien,sinh_vien,…
Vòng lặp foreach:	(Có tiền tố item + đối tượng)	itemSinhVien 
	SinhVien,sinh_vien,…
Exception	Thường dùng ex hoặc e	Exception ex	
enum		 eCHOOSE
	eCHOOSE 
  
### Object Control Win Form
Qui tắc:
Control type	prefix	Ví dụ
Form	frm	frmLogin
Label	lbl	lblHelpMessage
LinkLabel	llbl	llblAuthor
Button	btn	btnSave
TextBox	txt	txtHoTen
CheckBox	chk	chkReadOnly
RadioButton	rdo	rdoChonLop
ListBox	lsb	lsbLop
CheckedListBox	chklst	chklstDanhSach
ComboBox	cbo	cboMonHoc
ListView	lv	lvMonHoc
TreeView	tv	trPhong
DateTimePicker	dtp	dtpNgaySinh
Calendar	cal	calKeHoach
DataColumn	col	colNgaySinh
DataGrid	grd	grdDanhSach
DataGridTableStyle	dgts	dgtsUnion
DataGridTextBoxColumn	dgbc	dgbcHoTen
GroupBox	grp	grpHocKy
Image	img	imgIcon
PictureBox	pbx	pbxLogo
Panel	pnl	pnlTongHop
MainMenu	mnu	mnuTroGiup
MenuItem	mnu	mnuDanhSach
ContextMenu	ctxmnu	ctxmnuLop
TabControl	tab	tabHoSo
Timer	tmr	tmrXuLy
UserControl	uc	ucMyControl
ProgressBar	prg	prgLoadFile
RichTextBox	txt	txtReport
ImageList	imlst	imlstAllIcons
ToolBar	tlb	tlbActions
StatusBar	sta	staDateTime
Exception	ex	exSQL
OpenFileDialog	dlg	dlgOpenFileDialog
SaveFileDialog	dlg	dlgSaveFileDialog
FolderBrowserDialog	dlg	dlgFolderBrowserDialog
FontDialog	dlg	dlgFontDialog
ColorDialog	dlg	dlgColorDialog
PrintDialog	dlg	dlgPrintDialog
PrintPreviewDialog	dlg	dlgPrintDialog
PrintPreviewControl	prt	prtPrintPreviewControl
PrintDocument	prt	prtPrintDocument
ErrorProvider	err	errErrorProvider
  
### Style convention
Qui tắc:
	Tìm kiếm nhanh mã nguồn
•	Phân chia region: giúp cho việc tìm kiếm mã nguồn nhanh hơn: 
	Trong 1 class thì chia thành các vùng:Fields, Properties, Constructor, Methods, Operator.
•	Mã nguồn nhìn thấy trong một trang không kéo thả.
•	Một Method không quá 20 dòng.
•	Phân chia mỗi lớp vào 1 file riêng.
	Giảm thiểu các lỗi tiềm năng
•	Không viết một đoạn văn, chữ số mà không nói ý nghĩa.
	thay bằng const hoặc enum.
	Các const chung dồn vào 1 file class riêng để xử lý (hoặc đưa ra file config xml).
	Không để field public. Thay bằng sử dụng property.
  
 
### Solution Convention
Qui tắc:
Yêu cầu
	Ví dụ đúng
	Ví dụ sai

Các lớp không can thiệp vào tài nguyên tổng (ví dụ: màn hình, chuột,...)
	Chỉ viết Console ở class Program 
	Viết Console ở các lớp không phải main

Chương trình không bị chết, tắt ở giữa 
	sử dụng  try catch ở các Method/Event ngoài cùng
	 K sử dụng try catch ở các Method/Event ngoài cùng
Không nuốt lỗi
	try catch xong throw Exception
	try catch ở các Class không phải main Program
Đơn giản & làm rõ nghĩa mã nguồn
	Thay thế các lệnh if…else => if…return hoặc if…break
	
 

 
### Formatting Code
Qui tắc:
	Các đoạn code phải viết theo chuẩn (phải dùng Tab ở các đoạn If, While lồng nhau, mỗi Tab là 4 Space .
	Ngoặc nhọn  mở chứa khối code ở vị trí  bên trên
	Dấu phẩy đằng trước với nhiều thành phần.