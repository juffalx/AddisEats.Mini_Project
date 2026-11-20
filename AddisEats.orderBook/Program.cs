using AddisEats.OrderBook.Models;
using AddisEats.OrderBook.Services;


// ከስተመሩ መጥቶ ሚመለከተው የምግብ ዝርዝር ከነዋጋው
MenuItem Doro = new MenuItem(1,"doroWat","Tradetinal", 800m);
MenuItem Alicha = new MenuItem(2,"Alicha","Tradetinal", 600m);
MenuItem Tibs = new MenuItem(3,"Tibs","Tradetinal", 400m);
MenuItem Shiro = new MenuItem(4,"shiro","Tradetinal", 200m);


// ከስተመሩ 2 ዶሮ እና 1 ሽሮ መረጠ

OrderLine FirstChoose = new OrderLine
(
    Doro,
    2
);

OrderLine SecondChoose = new OrderLine
(
    Shiro,
    1
);


// የመረጡትን ምርጫ ትእዛዝ ወይም order   ሲያደርጉ

Order Order1 = new Order()
{
    Area = "Bole",
    Customer = "Elsabet",
    Lines = [FirstChoose, SecondChoose]
};



// Order የተደረጉት ደግሞ  OrderBook ላይ መመዝገብ አለባቸው 

OrderBook Book = new OrderBook();

Book.AddOrder(Order1);


Book.DisplayResult("Bole", 1);



