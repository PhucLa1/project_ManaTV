
CREATE DATABASE TVManagement;
Go
use TVManagement



--Tạo bảng hãng sản xuất
CREATE TABLE Manufacturer (
    id INT IDENTITY(1,1) PRIMARY KEY,
    manufacturer_name VARCHAR(25),
    manufacturer_address VARCHAR(50),
    manufacturer_status TINYINT DEFAULT 1
)

--Tạo bảng kiểu dáng
CREATE TABLE Designs(
    id INT IDENTITY(1,1) PRIMARY KEY,
    design_name VARCHAR(25),
    design_status TINYINT DEFAULT 1
)

--Tạo bảng màu sắc
CREATE TABLE Colors(
    id INT IDENTITY(1,1) PRIMARY KEY,
    color_name VARCHAR(25),
    color_value VARCHAR(20), -- Chú ý cột này để lưu giá trị màu, có thể là tên màu hoặc mã màu RGB
    color_status TINYINT DEFAULT 1
)

--Tạo bảng màn hình
CREATE TABLE Screen(
    id INT IDENTITY(1,1) PRIMARY KEY,
    screen_name VARCHAR(25),
    screen_status TINYINT DEFAULT 1
)

--Tạo bảng cỡ màn hình 
CREATE TABLE ScreenSize(
    id INT IDENTITY(1,1) PRIMARY KEY,
    screen_size FLOAT,
    size_status TINYINT DEFAULT 1
)

--Tạo bảng nước sản xuất
CREATE TABLE CountryOfManufacture(
    id INT IDENTITY(1,1) PRIMARY KEY,
    country_name VARCHAR(25),
    country_status TINYINT DEFAULT 1
)

--Tạo bảng sản phẩm 
CREATE TABLE Products(
    id INT IDENTITY(1,1) PRIMARY KEY,
    product_name VARCHAR(50),
    manufacturer_id INT,
    design_id INT,
    color_id INT,
    screen_id INT,
    size_id INT,
    country_id INT,
    product_amount INT,
    product_status TINYINT DEFAULT 1
)

--Tạo bảng ảnh
CREATE TABLE Images(
    id INT IDENTITY(1,1) PRIMARY KEY,
    product_id INT,
    image_path VARCHAR(100),
    image_status TINYINT DEFAULT 1
)



--Tạo bảng chi tiết hóa đơn bán
CREATE TABLE SellBillDetail(
    id INT IDENTITY(1,1) PRIMARY KEY,
    product_id INT,
    sell_amount INT,
    sell_voucher FLOAT,
    sell_bill_id INT,
    sell_detail_status TINYINT DEFAULT 1
)

--Tạo bảng hóa đơn bán
CREATE TABLE SellBill(
    id INT IDENTITY(1,1) PRIMARY KEY,
    sell_amount INT,
    customer_id INT,
    staff_id INT,
    sell_date DATE,
    sell_tax INT,
    sell_bill_status TINYINT DEFAULT 1
)

--Tạo bảng chi tiết hóa đơn nhập
CREATE TABLE ImportBillDetail(
    id INT IDENTITY(1,1) PRIMARY KEY,
    product_id INT,
    import_amount INT,
    import_voucher FLOAT,
    import_bill_id INT,
    import_detail_status TINYINT DEFAULT 1
)

--Tạo bảng hóa đơn nhập
CREATE TABLE ImportBill(
    id INT IDENTITY(1,1) PRIMARY KEY,
    import_amount INT,
    supplier_id INT,
    staff_id INT,
    import_date DATE,
    import_bill_status TINYINT DEFAULT 1
)

--Tạo bảng nhà cung cấp
CREATE TABLE Supplier(
    id INT IDENTITY(1,1) PRIMARY KEY,
    supplier_name VARCHAR(25),
    supplier_address VARCHAR(50),
    supplier_phoneNumber VARCHAR(11),
    supplier_status TINYINT DEFAULT 1
)

--Tạo bảng khách hàng
CREATE TABLE Customers(
    id INT IDENTITY(1,1) PRIMARY KEY,
    customer_name VARCHAR(25),
    customer_address VARCHAR(50),
    customer_phoneNumber VARCHAR(11),
    customer_status TINYINT DEFAULT 1
)

--Tạo bảng nhân viên 
CREATE TABLE Staff(
    id INT IDENTITY(1,1) PRIMARY KEY,
    staff_name VARCHAR(25),
    staff_gender BIT,
    staff_phoneNumber VARCHAR(11),
    staff_dob DATE,
    staff_address VARCHAR(50),
    staff_email VARCHAR(25),
    staff_work_id INT,
    staff_status TINYINT DEFAULT 1
)

--Tạo bảng Nhanvien_Calam
CREATE TABLE Staff_ShiftWork(
    id INT IDENTITY(1,1) PRIMARY KEY,
    staff_id INT,
    shiftwork_id INT,
    staff_shift_status TINYINT DEFAULT 1
)

--Tạo bảng Ca làm
CREATE TABLE ShiftWork(
    id INT IDENTITY(1,1) PRIMARY KEY,
    shiftwork_name VARCHAR(10),
    shiftwork_description VARCHAR(MAX),
    shiftwork_status TINYINT DEFAULT 1
)

--Tạo bảng công việc 
CREATE TABLE Work(
    id INT IDENTITY(1,1) PRIMARY KEY,
    work_name VARCHAR(50),
    work_description VARCHAR(MAX),
    work_status TINYINT DEFAULT 1
)


