create database KullaniciKayitDB
use KullaniciKayitDB

create table KullaniciBilgileri(
								KullaniciID int identity primary key,
								KullaniciMail nvarchar(200) not null,
								KullaniciSifre nvarchar(50) not null check(len(KullaniciSifre)>=8)
)

insert KullaniciBilgileri values('burakfatih@gmail.com', 'burakfatih')
insert KullaniciBilgileri values('erdinc_dincer@bilgeadam.com', 'erdincdincerUskudar')
insert KullaniciBilgileri values('yilmaz.uslu@gmail.com', 'Kadikoyyilmazuslu')
insert KullaniciBilgileri values('fatihkilicaslan@gmail.com', 'fatihkilicaslan2023')

select * from KullaniciBilgileri