HỆ THỐNG QUẢN LÝ VÀ PHÂN PHỐI VÉ SỰ KIỆN TRỰC TUYẾN TÍCH HỢP GỢI Ý SỰ KIỆN CÁ NHÂN HÓA

1. Giới thiệu đề tài
Đây là đồ án tốt nghiệp xây dựng website quản lý và phân phối vé sự kiện trực tuyến bằng ASP.NET Core MVC và SQL Server.
Hệ thống hỗ trợ khách hàng tìm kiếm sự kiện, đặt vé, thanh toán và quản lý vé đã mua. Ban tổ chức có thể tạo sự kiện, quản lý vé, theo dõi đơn hàng và kiểm tra vé khi người tham gia đến sự kiện. Quản trị viên thực hiện quản lý tài khoản, chủ đề và kiểm duyệt sự kiện.
Website còn tích hợp chức năng gợi ý sự kiện cá nhân hóa dựa trên sở thích và lịch sử tương tác của người dùng, đồng thời hỗ trợ tìm kiếm và khám phá sự kiện bằng ngôn ngữ tự nhiên.

2. Công nghệ sử dụng
- ASP.NET Core MVC (.NET 8): Nền tảng xây dựng website.
- C#: Ngôn ngữ lập trình xử lý các chức năng.
- HTML, CSS, JavaScript và Bootstrap: Xây dựng giao diện và xử lý tương tác.
- SQL Server: Lưu trữ và quản lý dữ liệu.
- Entity Framework Core Kết nối và thao tác với cơ sở dữ liệu.
- VNPay Sandbox: Hỗ trợ kiểm thử thanh toán trực tuyến.
- Gemini API: Hỗ trợ phân tích yêu cầu tìm kiếm bằng ngôn ngữ tự nhiên.

3. Cấu trúc thư mục
text
DATN_1150070041_CaoTongThienThu_11_DH_TMDT/
│
├── README.md
│
├── sourcecode/
│   ├── Controllers/
│   ├── Models/
│   ├── Views/
│   ├── Services/
│   ├── Data/
│   ├── wwwroot/
│   ├── appsettings.json
│   └── VeSuKienWeb.csproj
│
└── database/
    ├── CSDL_SuKien.sql
    └── TaiKhoanKiemThu.md

Trong đó:
- sourcecode: Chứa mã nguồn và các chức năng của website.
- Controllers: Tiếp nhận và xử lý các yêu cầu từ người dùng.
- Models: Chứa các lớp dữ liệu của hệ thống.
- Views: Chứa giao diện các trang website.
- Services: Chứa các chức năng xử lý, trong đó có gợi ý sự kiện.
- Data: Chứa các thành phần liên quan đến cơ sở dữ liệu.
- wwwroot: Chứa CSS, JavaScript, hình ảnh và các tài nguyên giao diện.
- database/CSDL_SuKien.sql: Tập tin SQL phục vụ tạo cơ sở dữ liệu và khôi phục dữ liệu được cung cấp.
- database/TaiKhoanKiemThu.md: Thông tin tài khoản kiểm thử theo từng vai trò.
- README.md: Hướng dẫn cài đặt, cấu hình và chạy chương trình.

4. Các chức năng chính

4.1. Khách hàng
- Đăng ký, đăng nhập và quản lý tài khoản.
- Xem, tìm kiếm, lọc và xem chi tiết sự kiện.
- Khảo sát và cập nhật sở thích cá nhân.
- Xem danh sách sự kiện được gợi ý.
- Quản lý các sự kiện yêu thích.
- Lựa chọn loại vé, số lượng vé và vị trí ghế nếu có.
- Đặt vé và thanh toán trực tuyến.
- Xem lịch sử đặt vé và mã QR của vé hợp lệ.
- Gửi yêu cầu hủy vé và theo dõi trạng thái xử lý.
- Tìm kiếm và khám phá sự kiện bằng ngôn ngữ tự nhiên.

4.2. Ban tổ chức
- Đăng nhập và quản lý sự kiện.
- Tạo, chỉnh sửa thông tin sự kiện.
- Thiết lập loại vé, giá vé và số lượng vé.
- Thiết kế sơ đồ chỗ ngồi.
- Theo dõi đơn đặt vé và thống kê sự kiện.
- Kiểm tra mã QR và thực hiện check-in.
- Phê duyệt hoặc từ chối yêu cầu hủy vé.
- Ghi nhận hoàn tiền sau khi xử lý.

4.3. Quản trị viên
- Quản lý tài khoản người dùng.
- Kiểm duyệt, phê duyệt hoặc từ chối sự kiện.
- Quản lý danh mục và chủ đề sự kiện.
- Theo dõi hoạt động và xem báo cáo thống kê.

5. Yêu cầu cài đặt
Trước khi chạy chương trình, cần chuẩn bị các phần mềm sau:

| Phần mềm | Mục đích |
| .NET 8 SDK | Biên dịch và chạy chương trình |
| SQL Server | Lưu trữ cơ sở dữ liệu |
| SQL Server Management Studio (SSMS) | Quản lý và khôi phục dữ liệu |
| Visual Studio 2022 hoặc Visual Studio Code | Mở và chạy mã nguồn |
| Microsoft Edge hoặc Google Chrome | Truy cập website |
| Git (không bắt buộc) | Tải và cập nhật mã nguồn |

Máy tính cần có kết nối Internet để sử dụng các chức năng tích hợp dịch vụ trực tuyến như VNPay và Gemini.

Nếu sử dụng Visual Studio 2022, cần cài đặt thành phần ASP.NET and web development và bảo đảm máy đã có .NET 8 SDK.

6. Hướng dẫn tải mã nguồn
Bước 1. Truy cập GitHub
Mở đường dẫn:
https://github.com/ththu23092004-commits/DATN_1150070041_CaoTongThienThu_11_DH_TMDT

Bước 2. Tải mã nguồn
Có thể tải chương trình theo một trong hai cách.
Cách 1: Download ZIP
1. Truy cập trang GitHub của đồ án.
2. Nhấn nút `Code`.
3. Chọn `Download ZIP`.
4. Giải nén tập tin vừa tải.
5. Mở thư mục đồ án sau khi giải nén.

Cách 2: Sử dụng Git
Mở Terminal hoặc PowerShell tại thư mục muốn lưu đồ án và chạy:
powershell
git clone https://github.com/ththu23092004-commits/DATN_1150070041_CaoTongThienThu_11_DH_TMDT.git

Sau khi tải xong, chuyển vào thư mục dự án:
powershell
cd DATN_1150070041_CaoTongThienThu_11_DH_TMDT

Kiểm tra các thư mục sourcecode, database và tập tin README.md.

7. Hướng dẫn cài đặt cơ sở dữ liệu SQL Server

Bước 1. Mở SQL Server Management Studio

1. Khởi động SQL Server Management Studio (SSMS).
2. Tại cửa sổ kết nối, chọn SQL Server đang sử dụng.
3. Chọn phương thức xác thực phù hợp:
   - Windows Authentication.
   - SQL Server Authentication.
4. Nhấn Connect.

Nếu sử dụng SQL Server Authentication, cần nhập tài khoản và mật khẩu SQL Server đã được cấu hình trên máy.

Bước 2. Mở tập tin cơ sở dữ liệu
Trong thư mục đồ án, truy cập:

text
database/CSDL_SuKien.sql

Tại SSMS:

1. Chọn File.
2. Chọn Open.
3. Chọn File.
4. Tìm đến tập tin CSDL_SuKien.sql.
5. Nhấn Open.

Nội dung các câu lệnh SQL sẽ được hiển thị trong cửa sổ truy vấn.

Bước 3. Tạo cơ sở dữ liệu

Cơ sở dữ liệu của hệ thống sử dụng tên:

sql
DatVe_SuKien

Nếu tập tin SQL đã chứa câu lệnh tạo cơ sở dữ liệu, thực hiện theo nội dung của tập tin.
Trường hợp tập tin chỉ chứa các câu lệnh tạo bảng và chưa có cơ sở dữ liệu, có thể tạo cơ sở dữ liệu mới bằng:

sql
CREATE DATABASE DatVe_SuKien;
GO

Sau đó lựa chọn cơ sở dữ liệu:

USE DatVe_SuKien;
GO

Lưu ý: Chỉ thực hiện các câu lệnh trên khi cơ sở dữ liệu chưa tồn tại. Cần đọc phần đầu tập tin SQL trước khi chạy để tránh tạo trùng hoặc thực hiện lại các câu lệnh không cần thiết.

Bước 4. Thực hiện tập tin SQL

1. Kiểm tra cơ sở dữ liệu đang được chọn.
2. Nhấn nút Execute hoặc phím F5.
3. Chờ SQL Server thực hiện các câu lệnh.
4. Kiểm tra thông báo tại phần Messages.
Nếu thành công, cơ sở dữ liệu sẽ được tạo theo các câu lệnh có trong tập tin.

Bước 5. Kiểm tra dữ liệu
Trong SSMS:
1. Mở Databases.
2. Chọn DatVe_SuKien.
3. Mở thư mục Tables.
4. Kiểm tra danh sách bảng.
Có thể sử dụng câu lệnh sau để xem dữ liệu sự kiện:

USE DatVe_SuKien;
GO

SELECT TOP 10 *
FROM dbo.SuKien;


Có thể xem các bảng khác như LoaiVe, DonHang và Ve để kiểm tra dữ liệu tương ứng.
Đối với bản dữ liệu mẫu, cần bảo đảm có dữ liệu phục vụ tìm kiếm sự kiện, đặt vé và kiểm thử chức năng gợi ý.

8. Hướng dẫn cấu hình chương trình

8.1. Cấu hình kết nối SQL Server
Trong thư mục `sourcecode`, mở tập tin:

text
appsettings.json

Tìm phần:

json
"ConnectionStrings"

Kiểm tra chuỗi kết nối đang được chương trình sử dụng và cập nhật theo SQL Server trên máy.

Một chuỗi kết nối tham khảo khi sử dụng Windows Authentication:

text
Server=.;Database=DatVe_SuKien;Trusted_Connection=True;TrustServerCertificate=True;

Trong đó:
- Server=.: SQL Server chạy trên máy hiện tại với instance mặc định.
- Database=DatVe_SuKien: Tên cơ sở dữ liệu.
- Trusted_Connection=True: Sử dụng Windows Authentication.
- TrustServerCertificate=True: Cho phép tin cậy chứng chỉ máy chủ SQL trong môi trường phát triển.

Nếu dùng SQL Server Express, tên máy chủ có thể là:

text
.\SQLEXPRESS

Khi sử dụng SQL Server Authentication, chuỗi kết nối cần có thông tin tài khoản SQL Server tương ứng.
Quan trọng: Giữ nguyên tên khóa chuỗi kết nối đang được mã nguồn sử dụng. Chỉ thay đổi thông số kết nối cho phù hợp với máy tính.

8.2. Kiểm tra cấu hình ứng dụng
Kiểm tra các tập tin cấu hình hiện có trong dự án, đặc biệt là:
- appsettings.json.
- Properties/launchSettings.json.
- Các tập tin cấu hình riêng của môi trường phát triển nếu được sử dụng.

Những thông tin cần kiểm tra:

- Kết nối SQL Server.
- Địa chỉ và cổng chạy website.
- Thông tin cấu hình thanh toán VNPay.
- Khóa Gemini API.
- Các dịch vụ khác mà chức năng đang sử dụng.

Không thay đổi tên khóa hoặc cấu trúc cấu hình nếu chưa đối chiếu với mã nguồn chương trình.

9. Hướng dẫn chạy chương trình bằng Visual Studio

Bước 1. Mở đồ án
1. Khởi động Visual Studio 2022.
2. Chọn `Open a project or solution`.
3. Truy cập thư mục `sourcecode`.
4. Chọn tập tin:

text
VeSuKienWeb.csproj

5. Nhấn Open.

Visual Studio sẽ tải các thành phần của dự án.

Bước 2. Kiểm tra .NET 8

Trong Visual Studio:

1. Nhấp chuột phải vào dự án.
2. Chọn Properties.
3. Kiểm tra Target Framework là .NET 8.

Nếu máy chưa có .NET 8 SDK, cần cài đặt trước khi biên dịch.

Bước 3. Khôi phục thư viện

Mở View → Terminal trong Visual Studio.

Tại thư mục chứa `VeSuKienWeb.csproj`, chạy:

powershell
dotnet restore .\VeSuKienWeb.csproj

Lệnh này khôi phục các thư viện cần thiết cho chương trình.

Bước 4. Biên dịch chương trình

Chạy lệnh:

powershell
dotnet build .\VeSuKienWeb.csproj

Nếu biên dịch thành công, Terminal hiển thị:

text
Build succeeded.

Nếu xuất hiện lỗi, cần kiểm tra nội dung thông báo trước khi chạy chương trình.

Bước 5. Chạy website

Có thể chạy bằng nút `Start` trong Visual Studio hoặc sử dụng lệnh:

powershell
dotnet run --project .\VeSuKienWeb.csproj

Sau khi khởi động thành công, Terminal hiển thị địa chỉ truy cập của website.

Ví dụ:

text
http://localhost:5000

Mở Microsoft Edge hoặc Google Chrome để truy cập địa chỉ vừa hiển thị.
Cổng truy cập có thể thay đổi theo cấu hình thực tế của dự án.

10. Hướng dẫn chạy bằng Visual Studio Code

Bước 1. Mở thư mục mã nguồn
1. Khởi động Visual Studio Code.
2. Chọn `File → Open Folder`.
3. Chọn thư mục `sourcecode`.
4. Nhấn `Select Folder`.

Bước 2. Mở Terminal

Trong Visual Studio Code, chọn:

text
Terminal → New Terminal

Kiểm tra Terminal đang ở thư mục chứa tập tin:

text
VeSuKienWeb.csproj

Bước 3. Khôi phục thư viện

Chạy:

powershell
dotnet restore .\VeSuKienWeb.csproj

Bước 4. Biên dịch chương trình

Chạy:

powershell
dotnet build .\VeSuKienWeb.csproj

Bước 5. Chạy website

Chạy:

powershell
dotnet run --project .\VeSuKienWeb.csproj

Sau khi hệ thống khởi động, mở trình duyệt và truy cập địa chỉ được thông báo trên Terminal.

Bước 6. Dừng chương trình

Khi muốn dừng website, quay lại Terminal đang chạy và nhấn:

text
Ctrl + C


11. Hướng dẫn cấu hình và kiểm thử VNPay Sandbox

Hệ thống sử dụng VNPay Sandbox để kiểm thử thanh toán trực tuyến.

11.1. Chuẩn bị tài khoản VNPay Sandbox

Để kiểm thử thanh toán, cần có thông tin cấu hình do VNPay Sandbox cung cấp.

Các thông tin thường được sử dụng gồm:

- Mã website hoặc mã đơn vị thanh toán (`TmnCode`).
- Khóa bí mật xác thực giao dịch (`HashSecret`).
- Địa chỉ cổng thanh toán thử nghiệm.
- Địa chỉ nhận kết quả thanh toán của website.

Thông tin tài khoản merchant dùng để quản lý giao dịch Sandbox không phải tài khoản đăng nhập của khách hàng trên website.

Các thông tin cấu hình VNPay cần được lấy từ tài khoản Sandbox tương ứng.

11.2. Cấu hình VNPay trong chương trình

Mở tập tin cấu hình VNPay đang được chương trình sử dụng.
Kiểm tra các giá trị:

- Mã website VNPay.
- Khóa bí mật VNPay.
- Địa chỉ cổng thanh toán.
- Địa chỉ nhận kết quả giao dịch.

Cập nhật giá trị theo thông tin VNPay Sandbox đã được cấp.
Cần giữ nguyên tên các khóa cấu hình đang được mã nguồn sử dụng.

11.3. Kiểm tra địa chỉ chạy website

Khởi động website bằng lệnh:

powershell
dotnet run --project .\VeSuKienWeb.csproj

Nếu website chạy tại:

text
http://localhost:5000

cần kiểm tra đường dẫn trả về của VNPay đã được cấu hình phù hợp.
Đối với trường hợp VNPay cần gửi thông báo trực tiếp đến website từ Internet, địa chỉ `localhost` không thể được VNPay truy cập từ bên ngoài.

Khi đó có thể sử dụng đường dẫn HTTPS công khai phục vụ kiểm thử, chẳng hạn thông qua Cloudflare Tunnel.

11.4. Sử dụng Cloudflare Tunnel khi cần

Nếu môi trường kiểm thử yêu cầu địa chỉ HTTPS công khai, cần cài đặt công cụ `cloudflared`.

Sau khi website chạy tại cổng `5000`, mở một Terminal khác và sử dụng:

powershell
cloudflared tunnel --url http://localhost:5000

Công cụ sẽ tạo một địa chỉ HTTPS tạm thời.

Sử dụng địa chỉ này để cấu hình đường dẫn nhận kết quả thanh toán nếu chương trình và tài khoản VNPay Sandbox yêu cầu.

Lưu ý:

- Giữ Terminal chạy website hoạt động.
- Giữ Terminal chạy Cloudflare Tunnel hoạt động.
- Không đóng Tunnel khi đang thực hiện giao dịch.
- Địa chỉ Quick Tunnel có thể thay đổi mỗi lần chạy.
- Cần cập nhật lại địa chỉ callback nếu địa chỉ HTTPS thay đổi.

11.5. Kiểm thử thanh toán

Thực hiện các bước sau:

1. Mở website và đăng nhập bằng tài khoản Khách hàng.
2. Chọn sự kiện đang được phép đặt vé.
3. Chọn loại vé và số lượng vé.
4. Chọn vị trí ghế nếu sự kiện có sơ đồ chỗ ngồi.
5. Xác nhận thông tin đặt vé.
6. Chọn thanh toán trực tuyến qua VNPay.
7. Hệ thống chuyển đến trang thanh toán VNPay Sandbox.
8. Thực hiện giao dịch bằng thông tin thanh toán thử nghiệm hợp lệ do VNPay cung cấp.
9. Hoàn tất bước xác thực theo yêu cầu của Sandbox.
10. Chờ hệ thống tiếp nhận kết quả giao dịch.

Sau khi giao dịch thành công, kiểm tra:

- Trạng thái thanh toán của đơn hàng.
- Thông tin vé đã đặt.
- Mã QR của vé hợp lệ.
- Thông tin giao dịch trong hệ thống.

Có thể đối chiếu với thông tin giao dịch tại trang quản lý VNPay Sandbox nếu tài khoản merchant được cấp quyền truy cập.

Lưu ý: VNPay Sandbox chỉ phục vụ kiểm thử, không thực hiện thanh toán bằng tiền thật.

12. Hướng dẫn cấu hình Gemini API

Website tích hợp Gemini API để hỗ trợ phân tích yêu cầu tìm kiếm sự kiện bằng ngôn ngữ tự nhiên.

12.1. Chuẩn bị khóa API

Cần có khóa Gemini API hợp lệ để sử dụng chức năng khám phá sự kiện.
Khóa API được tạo và quản lý thông qua dịch vụ tương ứng của Google.

12.2. Cấu hình khóa API

Mở tập tin cấu hình mà chương trình đang sử dụng cho Gemini.
Tìm khóa cấu hình được mã nguồn dùng để đọc Gemini API Key.
Cập nhật giá trị bằng khóa API hợp lệ.
Không thay đổi tên khóa cấu hình khi chưa kiểm tra mã nguồn.

12.3. Kiểm thử chức năng

1. Khởi động website.
2. Mở chức năng khám phá sự kiện.
3. Nhập yêu cầu tìm kiếm bằng tiếng Việt.

Ví dụ:
text
Tôi muốn tìm sự kiện âm nhạc ở TP.HCM,
giá vé dưới 500.000 đồng.

Hệ thống phân tích yêu cầu, xác định các điều kiện tìm kiếm và truy vấn dữ liệu sự kiện.
Người dùng có thể tiếp tục bổ sung hoặc thay đổi nhu cầu trong cuộc hội thoại.

Ví dụ:

text
Có sự kiện nào phù hợp vào cuối tuần không?

Chức năng này sử dụng Gemini để hỗ trợ phân tích yêu cầu. Danh sách sự kiện được tìm kiếm từ dữ liệu của hệ thống.
Kết quả phụ thuộc vào dữ liệu sự kiện hiện có và trạng thái hoạt động của dịch vụ Gemini API.

13. Hướng dẫn sử dụng tài khoản kiểm thử

Hệ thống có ba nhóm người dùng chính:
- Khách hàng.
- Ban tổ chức.
- Quản trị viên.

Thông tin đăng nhập được cung cấp tại:

text
database/TaiKhoanKiemThu.md

13.1. Tài khoản Khách hàng

1. Mở website.
2. Chọn chức năng đăng nhập.
3. Nhập tài khoản Khách hàng được cung cấp.
4. Sau khi đăng nhập, thực hiện các chức năng tìm kiếm, yêu thích và đặt vé.

Để kiểm tra chức năng gợi ý cá nhân hóa:

1. Khảo sát hoặc cập nhật sở thích.
2. Xem chi tiết một số sự kiện.
3. Thêm sự kiện vào danh sách yêu thích.
4. Xem danh sách sự kiện gợi ý.
5. Kiểm tra sự thay đổi của kết quả gợi ý theo dữ liệu tương tác.

13.2. Tài khoản Ban tổ chức

1. Đăng nhập bằng tài khoản có quyền Ban tổ chức.
2. Truy cập khu vực quản lý sự kiện.
3. Tạo hoặc chỉnh sửa một sự kiện.
4. Thiết lập loại vé và số lượng vé.
5. Tạo sơ đồ ghế nếu cần.
6. Theo dõi các đơn đặt vé.
7. Kiểm tra mã QR và thực hiện check-in.
8. Xử lý yêu cầu hủy vé của khách hàng.

Các sự kiện được tạo cần trải qua bước kiểm duyệt theo quy trình của hệ thống trước khi được hiển thị công khai.

13.3. Tài khoản Quản trị viên

1. Đăng nhập bằng tài khoản Quản trị viên.
2. Truy cập khu vực quản trị.
3. Kiểm tra danh sách sự kiện chờ duyệt.
4. Phê duyệt hoặc từ chối sự kiện.
5. Quản lý tài khoản người dùng.
6. Quản lý danh mục và chủ đề sự kiện.
7. Theo dõi hoạt động và xem báo cáo thống kê.

Tài khoản kiểm thử cần được chuẩn bị sẵn trong dữ liệu mẫu hoặc tạo theo đúng cơ chế phân quyền của hệ thống.

14. Chức năng gợi ý sự kiện cá nhân hóa

Hệ thống sử dụng phương pháp Content-Based Filtering kết hợp Cosine Similarity để xác định mức độ phù hợp giữa người dùng và sự kiện.
Thông tin được sử dụng gồm:

- Chủ đề người dùng lựa chọn trong khảo sát.
- Lịch sử xem chi tiết sự kiện.
- Các sự kiện đã yêu thích.
- Thông tin đặt vé đáp ứng điều kiện ghi nhận của hệ thống.

Từ các dữ liệu này, hệ thống xây dựng hồ sơ sở thích và lựa chọn danh sách sự kiện phù hợp để hiển thị.

14.1. Mã nguồn xử lý gợi ý

Các thành phần liên quan gồm:

text
sourcecode/Services/GoiYSuKienService.cs

Tập tin này chứa các xử lý phục vụ việc xây dựng hồ sơ sở thích và đề xuất sự kiện.

14.2. Mã nguồn đánh giá
Các thành phần phục vụ đánh giá gồm:

text
sourcecode/Services/DanhGiaGoiYService.cs
sourcecode/Controllers/DanhGiaGoiYController.cs
sourcecode/Controllers/DanhGiaHangLoatController.cs

Các thành phần này hỗ trợ tính toán chỉ số và kiểm thử kết quả gợi ý.

14.3. Phương pháp kiểm thử

Kết quả gợi ý được xem xét thông qua các chỉ số:

- Precision@K.
- Recall@K.
- NDCG@K.

Các chỉ số được sử dụng để đánh giá mức độ phù hợp và thứ tự của danh sách sự kiện được đề xuất.
Đối với dữ liệu đánh giá mô phỏng, cần phân biệt kết quả kiểm thử thuật toán với kết quả đánh giá từ người dùng thực tế.
Hệ thống không thực hiện huấn luyện mô hình máy học riêng. Việc gợi ý dựa trên dữ liệu người dùng, thông tin sự kiện và phương pháp tính độ tương đồng.

15. Hướng dẫn kiểm tra một số chức năng
15.1. Kiểm tra đặt vé

1. Đăng nhập bằng tài khoản Khách hàng.
2. Chọn sự kiện.
3. Chọn loại vé và số lượng.
4. Chọn ghế nếu có.
5. Xác nhận đơn đặt vé.
6. Thực hiện thanh toán.
7. Kiểm tra đơn hàng và vé tương ứng.

15.2. Kiểm tra mã QR

1. Đăng nhập bằng tài khoản Khách hàng.
2. Truy cập mục quản lý vé.
3. Chọn vé hợp lệ.
4. Xem mã QR.

Để kiểm tra check-in:

1. Đăng nhập bằng tài khoản Ban tổ chức.
2. Mở chức năng kiểm tra vé.
3. Kiểm tra mã QR của vé.
4. Thực hiện check-in nếu vé đáp ứng điều kiện.

15.3. Kiểm tra hủy vé

1. Đăng nhập bằng tài khoản Khách hàng.
2. Chọn đơn vé đáp ứng điều kiện hủy.
3. Gửi yêu cầu hủy vé.
4. Đăng nhập bằng tài khoản Ban tổ chức.
5. Xem và xử lý yêu cầu hủy.
6. Kiểm tra trạng thái sau khi xử lý.

Trường hợp yêu cầu hủy được phê duyệt, hệ thống ghi nhận kết quả theo quy trình hủy vé và hoàn tiền đã xây dựng.

15.4. Kiểm tra gợi ý sự kiện

1. Đăng nhập bằng tài khoản Khách hàng.
2. Cập nhật các chủ đề quan tâm.
3. Truy cập và yêu thích một số sự kiện.
4. Mở danh sách gợi ý cá nhân hóa.
5. Quan sát các sự kiện được đề xuất.

15.5. Kiểm tra khám phá sự kiện

1. Mở chức năng khám phá sự kiện.
2. Nhập điều kiện tìm kiếm bằng tiếng Việt.
3. Quan sát danh sách sự kiện được trả về.
4. Tiếp tục bổ sung hoặc thay đổi yêu cầu.
5. Kiểm tra phản hồi của hệ thống trong trường hợp có hoặc không có sự kiện phù hợp.

16. Một số lỗi thường gặp

16.1. Không kết nối được SQL Server

Nguyên nhân có thể do:

- SQL Server chưa được khởi động.
- Sai tên Server hoặc Instance.
- Sai tên cơ sở dữ liệu.
- Sai tài khoản hoặc mật khẩu SQL Server.
- Phương thức xác thực chưa phù hợp.

Cách xử lý:

1. Mở SSMS để kiểm tra kết nối.
2. Kiểm tra SQL Server đang hoạt động.
3. Kiểm tra tên cơ sở dữ liệu.
4. Kiểm tra chuỗi kết nối trong `appsettings.json`.
5. Chạy lại chương trình.

16.2. Không biên dịch được chương trình

Kiểm tra phiên bản .NET đang cài đặt:

powershell
dotnet --version

Kiểm tra danh sách SDK:

powershell
dotnet --list-sdks

Khôi phục lại thư viện:

powershell
dotnet restore .\VeSuKienWeb.csproj

Biên dịch lại:

powershell
dotnet build .\VeSuKienWeb.csproj

Nếu vẫn có lỗi, cần đọc thông báo trong Terminal để xác định tập tin và nguyên nhân cụ thể.

16.3. Cổng chạy website đang được sử dụng

Nếu cổng mặc định đã có chương trình khác sử dụng, có thể chạy bằng cổng khác:

powershell
dotnet run --project .\VeSuKienWeb.csproj --urls "http://localhost:5050"

Sau đó truy cập:

text
http://localhost:5050

Khi thay đổi cổng chạy website, cần kiểm tra lại các địa chỉ callback của dịch vụ thanh toán nếu đang sử dụng.

16.4. Thanh toán VNPay không trả kết quả

Kiểm tra:

- Thông tin cấu hình VNPay Sandbox.
- Địa chỉ trả về của website.
- Đường dẫn callback.
- Trạng thái Cloudflare Tunnel nếu đang sử dụng.
- Trạng thái kết nối Internet.

Nếu Tunnel đã dừng hoặc địa chỉ HTTPS thay đổi, cần khởi động lại và cập nhật cấu hình tương ứng.

16.5. Chức năng khám phá sự kiện không phản hồi

Kiểm tra:

- Kết nối Internet.
- Gemini API Key.
- Trạng thái hoạt động và hạn mức của dịch vụ Gemini.
- Thông báo lỗi trong Terminal.
- Dữ liệu sự kiện hiện có trong SQL Server.

17. Một số lưu ý khi sử dụng

- SQL Server cần hoạt động trước khi chạy website.
- Chuỗi kết nối phải phù hợp với máy tính đang sử dụng.
- Các tài khoản phải có đúng quyền truy cập.
- VNPay Sandbox chỉ phục vụ kiểm thử thanh toán.
- Chức năng khám phá sự kiện cần có Gemini API Key hợp lệ.
- Kết quả gợi ý phụ thuộc vào dữ liệu sở thích và lịch sử tương tác.
- Dữ liệu kiểm thử cần phù hợp với các chức năng được thực hiện.
- Không sử dụng tài khoản cá nhân hoặc khóa dịch vụ thật làm thông tin đăng nhập công khai.

18. Thông tin đồ án

Tên đề tài: Xây dựng hệ thống quản lý và phân phối vé sự kiện trực tuyến tích hợp gợi ý sự kiện cá nhân hóa.

Sinh viên thực hiện: Cao Tống Thiên Thư

Mã số sinh viên: 1150070041

Lớp: 11_ĐH_TMĐT

Loại dự án: Đồ án tốt nghiệp

Mục đích: Phục vụ học tập, nghiên cứu và thực nghiệm hệ thống quản lý, đặt vé và gợi ý sự kiện trực tuyến.
