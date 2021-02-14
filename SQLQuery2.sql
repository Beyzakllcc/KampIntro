--Select
--ANSII
Select ContactName Adi, CompanyName Sirketadi, City Sehir from Customers
Select * from Customers where City = 'Berlin' 
--case sensitive
Select * from Products where CategoryID = 1 or CategoryID  = 3
Select * from Products where CategoryID = 1 and UnitPrice  >= 10
Select * from Products order by ProductName 
Select * from Products order by CategoryID, ProductName --Id leri adlarına göre kendi içinde sırala
Select * from Products where CategoryID = 1 order by UnitPrice desc  --ascending Küçükten büyüğe default -- descending Büyükten küçüğe sırala
Select count(*) from Products where CategoryID = 2
Select count(*)Adet From Products
Select CategoryID , count(*) from products group by CategoryID
Select CategoryID , count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10 --içinde 10dan az ürün olan kategorileri almak için 
Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10--Bu şart geçerliyse bi araya getir demek
--DTO Data Transformation Object
Select * from Products p left join [Order Details] od --Tablo ismi olarak algılamak için köşeli parantezli yazdık.
on p.ProductID = od.ProductID
inner join Orders o --Başka bir tabloyu daha birleştirmek istersek bu şekilde yapmalıyız.
on o.OrderID=od.OrderID
Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID 
where o.CustomerID is null --Hiç ürün almayan kişileri getirir.


