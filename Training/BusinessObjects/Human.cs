using System.Collections.Generic;
using System.Linq;

namespace Training.BusinessObjects
{
    public static class Database
    {
        public static List<Currency> Currencies = new List<Currency>()
            {Currency.EUR, Currency.GEL, Currency.USD, Currency.RUB};
        // ReSharper disable once FieldCanBeMadeReadOnly.Global
        public static List<Client> Clients = new[]
        {
            Client.მერაბზარიძე,
            Client.ნათიასიდამონიძე,
            Client.ნათიასიდამონიძე,
            Client.დოლიძეინგა,
            Client.რამაზგულიაშვილი,
            Client.ირაკლიპაიჭაძე,
            Client.სეხნიაშვილითემურ,
            Client.სეხნიაშვილითემურ,
            Client.ლედიცინაური,
            Client.ლედიცინაური,
            Client.გივიალადაშვილი,
            Client.ზაზასიჭინავა,
            Client.ზაზასიჭინავა,
            Client.კობამამინაიშვილი,
            Client.ნიკოლოზჩაფიჩაძე,
            Client.ტარიელტაბატაძე,
            Client.მალხაზმჭედლიშვილი,
            Client.გიორგიჩოხელი,
            Client.იოსებსარალიძე,
            Client.რევაზაბრამიშვილი,
            Client.რევაზაბრამიშვილი,
            Client.კახაბერფაჟავა,
            Client.ზურაბქურდობაძე,
            Client.ყაჩმაზოვითენგიზი,
            Client.vefxiSvililaSa,
            Client.ლევანმეგრელაძე,
            Client.ქეთევანცნობილაძე,
            Client.მარინაგელაშვილი,
            Client.სხირტლაძეივანე,
            Client.ლაცაბიძეზვიადი,
            Client.კოპაძესოფიკო,
            Client.როსტიაშვილილიანა,
            Client.პავლიაშვილილევან,
            Client.ხიზანიშვილილაშა,
            Client.მაისურაძენიკოლოზ,
            Client.მადონანაცვლიშვილი,
            Client.შოშიტაშვილიგიორგი,
            Client.გასანოვინოვრუზ,
            Client.სხილაძეზურაბ,
            Client.ივეჩიანიგოგა,
            Client.შაინიძედავით,
            Client.რომანკეკელიძე,
            Client.ოთარგულიკაშვილი,
            Client.გიგაშვილიქრისტინე,
            Client.სალომედავითულიანი,
            Client.დავითბულიავა,
            Client.დოდონაჭყებია,
            Client.ნანიშელია,
            Client.ეკატერინექლიბაძე,
            Client.აიდინჯავადოვი,
            Client.ზაქარიაძეჯანსულ,
            Client.თამაზბერიძე,
            Client.ბარნაბიშვილითეონა,
            Client.გოჩაკაპანაძე,
            Client.მაჩიტიძეკობა,
            Client.კრიხელითამარი,
            Client.გელაჯაბნიძე,
            Client.შალვასუქასოვი,
            Client.მარინეგაზაშვილი,
            Client.მარინეგაზაშვილი,
            Client.გიორგიღვალაძე,
            Client.ძიძიგურიზაზა,
            Client.ქოქაშვილიზვიად,
            Client.ქაფიანიძედავით,
            Client.რატიავალერიანი,
            Client.რატიავალერიანი,
            Client.თიგიშვილირობერტი,
            Client.ბუბუტეიშვილიმამია,
            Client.ციციშვილითაიზი,
            Client.barbaqaZeTamar,
            Client.ზაზანოზაძე,
            Client.ხოსიტაშვილიზურაბი,
            Client.ხმალაძეანა,
            Client.ელზახაჭაპურიძე,
            Client.შოთახელაძე,
            Client.დედალამაზიშვილიდალი,
            Client.გიორგიცომაია,
            Client.პავლიაშვილინუკრი,
            Client.ილიაკორინთელი,
            Client.ნატალიაქადაგიძე,
            Client.ხუციშვილიზაზა,
            Client.რამაზლაშხია,
            Client.ზურაბჩიხელიძე,
            Client.წიქარიშვილინანა,
            Client.ბეგლარიშვილისოფიკო,
            Client.საჩეჩელაშვილიმანანა,
            Client.გიორგიკაკაშვილი,
            Client.კუსრაშვილიმიხეილი,
            Client.მიხეილშამოევი,
            Client.ვიბლიანიმაკა,
            Client.გაბოძენინელი,
            Client.თორნიკეჯოხაძე,
            Client.ბენიამინხუსკივაძე,
            Client.იაგუბოვიიფრატ,
            Client.ჯავახიშვილიდავითი,
            Client.ხაჩიძეეკატერინე,
            Client.რუსუდანელიავა,
            Client.ქაჯაიაირაკლი,
            Client.ბაქრაძეგიორგი,
            Client.ჩალაბაშვილიგიგა,
            Client.მამარიანიმურაზ,
            Client.ეთერკორკოტაშვილი,
            Client.ეთერკორკოტაშვილი,
            Client.ეთერკორკოტაშვილი,
            Client.ჯანაშვილიზვიადი,
            Client.ჯანაშვილიზვიადი,
            Client.ჩილაჩავაკობა,
            Client.ოგნაძეინგა,
            Client.ფანცხავასოფიო,
            Client.კალანდაძეთემურ,
            Client.გრიგალაშვილიცისანა,
            Client.ვიქტორიაპოლოზენკო,
            Client.მათიაშვილინოდარ,
            Client.სოფიოდონდუა,
            Client.ჭოლაძემანანა,
            Client.ინეზაჯაბუა,
            Client.ანაყავლაშვილი,
            Client.არაბულიმამუკა,
            Client.ჭოლაძემანანა,
            Client.ფურცხვანიძესოფიო,
            Client.ბექაცერცვაძე,
            Client.ვიქტორიაპოლოზენკო,
            Client.გიორგიბეროშვილი,
            Client.გურჩიანივიქტორია,
            Client.იმერლიშვილიმარინე,
            Client.იმერლიშვილიმარინე,
            Client.ხიზანიშვილიგვანცა,
            Client.კალატოზიშვილიქეთევანი,
            Client.ლავრენტლასარეიშვილი,
            Client.დავითსახვაძე,
            Client.გამრეკელითამარ,
            Client.ტეფნაძეთეონა,
            Client.ჭანტურიძეთეიმურაზ,
            Client.ჩინჩახაშვილითამარი,
            Client.გელაშვილიკობა,
            Client.იაკობიშვილიირაკლი,
            Client.იუზათედეევა,
            Client.იმედამიქელაძე,
            Client.boWoriSvilimamuka,
            Client.უნგიაძეირინა,
            Client.სულხანიშვილიგიორგი,
            Client.ანზორიხუციძე,
            Client.ინაელიბეკოვა,
            Client.ინაელიბეკოვა,
            Client.ვანობებუთაშვილი,
            Client.აკაკირუაძე,
            Client.ლევანგაგნიძე,
            Client.დავითცერცვაძე,
            Client.ნიკოლოზინასარიძე,
            Client.ჯუმბერშუბითიძე,
        }.ToList();

        public static List<Account> Accounts = new[]
        {
            288870210019588, 288870210019589, 288870210019590, 288870210019591, 288870210019592,
            288870210019593, 288870210019594, 288870210019595, 288870210019596, 288870210019597, 288870210019598,
            288870210019599,
            288870210019600, 288870210019601, 288870210019602, 288870210019603, 288870210019604, 288870210019605,
            288870210019606, 288870210019607,
            288870210019608, 288870210019609, 288870210019610, 288870210019611, 288870210019612, 288870210019613,
            288870210019614, 288870210019615,
            288870210019616, 288870210019617, 288870210019618, 288870210019619, 288870210019620, 288870210019621,
            288870210019622, 288870210019623,
            288870210019624, 288870210019625, 288870210019626, 288870210019627, 288870210019628, 288870210019629,
            288870210019630, 288870210019631,
            288870210019632, 288870210019633, 288870210019634, 288870210019635, 288870210019636, 288870210019637,
            288870210019638, 288870210019639,
            288870210019640, 288870210019641, 288870210019642, 288870210019643, 288870210019644, 288870210019645,
            288870210019646, 288870210019647,
            288870210019648, 288870210019649, 288870210019650, 288870210019651, 288870210019652, 288870210019653,
            288870210019654, 288870210019655,
            288870210019656, 288870210019657, 288870210019658, 288870210019659, 288870210019660, 288870210019661,
            288870210019662, 288870210019663,
            288870210019664, 288870210019665, 288870210019666, 288870210019667, 288870210019668, 288870210019669,
            288870210019670, 288870210019671,
            288870210019672, 288870210019673, 288870210019674, 288870210019675, 288870210019676, 288870210019677,
            288870210019678, 288870210051028,
            288870210051029, 288870210051030, 288870210051031, 288870210051032, 288870210051033, 288870210051034,
            288870210051035, 288870210051036,
            288870210051037, 288870210051038, 288870210051039, 288870210051040, 288870210051041, 288870210051042,
            288870210051043, 288870210051044,
            288870210051045, 288870210051046, 288870210051047, 288870210051048, 288870210051049, 288870210051050,
            288870210051051, 288870210051052, 288870210051053, 288870210051054, 288870210051055, 288870210051056,
            288870210051057, 288870210051058, 288870210051059, 288870210051060, 288870210051061, 288870210051062,
            288870210051063, 288870210051064, 288870210051065, 288870210051066, 288870210051067, 288870210051068,
            288870210051069, 288870210051070, 288870210051071, 288870210051072, 288870210051073, 288870210051074,
            288870210051075, 288870210051076, 288870210051077, 288870210051078, 288870210051079, 288870210051080,
            288870210051081, 288870210051082, 288870210051083, 288870210051084, 288870210051085, 288870210051086,
            288870210051087, 288870210051088, 288870210051089, 288870210051090, 288870210051091, 288870210051092,
            288870210051093, 288870210051094, 288870210051095, 288870210051096, 288870210051097, 288870210051098,
            288870210051099, 288870210051100, 288870210051101, 288870210051102, 288870210051103, 288870210051104,
            288870210051105, 288870210051106, 288870210051107, 288870210051108, 288870210051109, 288870210051110,
            288870210051111, 288870210051112, 288870210051113, 288870210051114, 288870210051115, 288870210051116,
            288870210051117, 288870210052469, 288870210052470, 288870210052471, 288870210052472, 288870210052473,
            288870210052474, 288870210052475, 288870210052476, 288870210052477, 288870210052478, 288870210052479,
            288870210052480, 288870210052481, 288870210052482, 288870210052483, 288870210052484, 288870210052485,
            288870210052486, 288870210052487, 288870210052488, 288870210052489, 288870210052490, 288870210052491,
            288870210052492, 288870210052493, 288870210052494, 288870210052495, 288870210052496, 288870210052497,
            288870210052498, 288870210052499, 288870210052500, 288870210052501, 288870210052502, 288870210052503,
            288870210052504, 288870210052505, 288870210052506, 288870210052507, 288870210052508, 288870210052509,
            288870210052510, 288870210052511, 288870210052512, 288870210052513, 288870210052514, 288870210052515,
            288870210052516, 288870210052517, 288870210052518, 288870210052519, 288870210052520, 288870210052521,
            288870210052522, 288870210052523, 288870210052524, 288870210052525, 288870210052526, 288870210052527,
            288870210052528, 288870210052529, 288870210052530, 288870210052531, 288870210052532, 288870210052533,
            288870210052534, 288870210052535, 288870210052536, 288870210052537, 288870210052538, 288870210052539,
            288870210052540, 288870210052541, 288870210052542, 288870210052543, 288870210052544, 288870210052545,
            288870210052546, 288870210052547, 288870210052548, 288870210052549, 288870210052550, 288870210052551,
            288870210052552, 288870210052553, 288870210052554, 288870210052555, 288870210052556, 288870210052557,
            288870210052558, 288870210052559, 288870210054123, 288870210054124, 288870210054125, 288870210054126,
            288870210054127, 288870210054128, 288870210054129, 288870210054130, 288870210054131, 288870210054132,
            288870210054133, 288870210054134, 288870210054135, 288870210054136, 288870210054137, 288870210054138,
            288870210054139, 288870210054140, 288870210054141, 288870210054142, 288870210054143, 288870210054144,
            288870210054145, 288870210054146, 288870210054147, 288870210054148, 288870210054149, 288870210054150,
            288870210054151, 288870210054152, 288870210054153, 288870210054154, 288870210054155, 288870210054156,
            288870210054157, 288870210054158, 288870210054159, 288870210054160, 288870210054161, 288870210054162,
            288870210054163, 288870210054164, 288870210054165, 288870210054166, 288870210054167, 288870210054168,
            111110011390001, 111110011397000, 111110011403000, 111110011404000, 111110011406000, 111110011409000,
            111110011410000, 111110011412000, 111110011417000, 111110011424000, 111110011431000, 111110011444000,
            111110011453000,
            111110011454000, 111110011457000, 111110011460000, 111110011467000, 111110011468000, 111110011481000,
            111110011484000, 111110011485000,
            111110011489000, 111110011492000, 111110011493000, 111110011494000, 111110011495000, 111110011496000,
            111110011507000, 111110011509000,
            111110011510000, 111110011518000, 111110011525000, 111110011529000, 111110011537000, 111110011540000,
            111110011548000, 111110011549000, 111110011555000,
            111110011561000, 111110011572000, 111110011574000, 111110011577000, 111110011581000, 111110011592000,
            111110011593000, 111110011595000,
            111110011599000, 111110011601000, 111110011603000,
        }.Select(x => x.ToString()).Select(x => new Account(x)).ToList();
    }

    public abstract class Human
    {
        public Human(string fullName)
        {
            FullName = fullName;
            FirstName = GetFirstName();
            LastName = GetLastName();
        }

        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFirstName()
        {
            var SplitFullname = SplitFullName();
            var firstName = SplitFullname.First();
            return firstName;
        }

        private string[] SplitFullName() => FullName.Split(' ');

        public string GetLastName()
        {
            var SplitFullname = SplitFullName();
            var lastName = SplitFullname.Last();
            return lastName;
        }

        public static Client უსოევიმიხეილ = new Client("უსოევი მიხეილ");
        public static Client ჟორდანიაზვიად = new Client("ჟორდანია ზვიად");
        public static Client ლუცუფიძეგიორგი = new Client("ლუცუფიძე გიორგი");
        public static Client კოკოზაშვილიგიორგი = new Client("კოკოზაშვილი გიორგი");
        public static Client გოჩოლეიშვილიგიორგი = new Client("გოჩოლეიშვილი გიორგი");
        public static Client მოსიათამთა = new Client("მოსია თამთა");
        public static Client ჩიტიშვილიმიხეილ = new Client("ჩიტიშვილი მიხეილ");
        public static Client გახოკიაბაჩუკი = new Client("გახოკია ბაჩუკი");
        public static Client ბიბილეიშვილიირინა = new Client("ბიბილეიშვილი ირინა");
        public static Client ბარამიძეშაკო = new Client("ბარამიძე შაკო");
        public static Client ჯიოევიზურაბ = new Client("ჯიოევი ზურაბ");
        public static Client შიანოვგიორგი = new Client("შიანოვ გიორგი");
        public static Client გოდიშვილიმალხაზ = new Client("გოდიშვილი მალხაზ");
        public static Client საჯაიარამაზ = new Client("საჯაია რამაზ");
        public static Client ანაშონია = new Client("ანა შონია");
        public static Client შონიაანა = new Client("შონია ანა");
        public static Client მაისურაძეგია = new Client("მაისურაძე გია");
        public static Client ლევანბერძენიშვილი = new Client("ლევან ბერძენიშვილი");
        public static Client ჯორბენაძენანა = new Client("ჯორბენაძე ნანა");
        public static Client მსხვილიძეამირან = new Client("მსხვილიძე ამირან");
        public static Client ეიბოვიბრაგიმ = new Client("ეიბოვ იბრაგიმ");
        public static Client შუბითიძეჯემალი = new Client("შუბითიძე ჯემალი");
        public static Client ზვიადბელაუსოვი = new Client("ზვიად ბელაუსოვი  ");
        public static Client ბელაუსოვიზვიად = new Client("ბელაუსოვი ზვიად");
        public static Client ქვირიამიხეილ = new Client("ქვირია მიხეილ");
        public static Client ირაკლიდუნდუა = new Client("ირაკლი დუნდუა");
        public static Client ხაჩიძეხვიჩა = new Client("ხაჩიძე ხვიჩა");
        public static Client გასანოვითამაზ = new Client("გასანოვი თამაზ");
        public static Client ლევანგუჯაბიძე = new Client("ლევან გუჯაბიძე");
        public static Client ფეიქრიშვილიგიორგი = new Client("ფეიქრიშვილი გიორგი");
        public static Client გიაწაველიძე = new Client("გია წაველიძე");
        public static Client გადელიაგიორგი = new Client("გადელია გიორგი");
        public static Client კუპატაძენაირა = new Client("კუპატაძე ნაირა");
        public static Client გიორგიჩხეიძე = new Client("გიორგი ჩხეიძე");
        public static Client გიორგიგადელია = new Client("გიორგი გადელია");
        public static Client ზაქროსახიაშვილი = new Client("ზაქრო სახიაშვილი");
        public static Client მიქაძეკახაბერ = new Client("მიქაძე კახაბერ");
        public static Client იაკობიშვილიირაკლი = new Client("იაკობიშვილი ირაკლი");
        public static Client გიორგიმაღალდაძე = new Client("გიორგი მაღალდაძე");
        public static Client ამონაშვილიზვიადი = new Client("ამონაშვილი ზვიადი");
        public static Client ბეჟანჯინჭარაძე = new Client("ბეჟან ჯინჭარაძე");
        public static Client მერაბპაპასკუა = new Client("მერაბ პაპასკუა");
        public static Client ვასილკურტანიძე = new Client("ვასილ კურტანიძე");
        public static Client თორნიკეკაპანაძე = new Client("თორნიკე კაპანაძე");
        public static Client ათაბაგილიანა = new Client("ათაბაგი ლიანა");
        public static Client ჩაბრაძეშაქრო = new Client("ჩაბრაძე შაქრო");
        public static Client ჯემალალოიანი = new Client("ჯემალ ალოიანი");
        public static Client ალოიანიჯემალ = new Client("ალოიანი ჯემალ");
        public static Client ამირანფეტვიაშვილი = new Client("ამირან ფეტვიაშვილი");
        public static Client გვაჯაიათენგიზ = new Client("გვაჯაია თენგიზ");
        public static Client მაღრაძელევანი = new Client("მაღრაძე ლევანი");
        public static Client პაპიძეემზარ = new Client("პაპიძე ემზარ");
        public static Client ქუთათელაძეგიორგი = new Client("ქუთათელაძე გიორგი");
        public static Client ჯანელიძეალეკო = new Client("ჯანელიძე ალეკო");
        public static Client ისაევაალვინა = new Client("ისაევა ალვინა");
        public static Client ბალხამიშვილიმაია = new Client("ბალხამიშვილი მაია");
        public static Client ალბოროვაჟანა = new Client("ალბოროვა ჟანა");
        public static Client ზაქარიაყალაყაშვილი = new Client("ზაქარია ყალაყაშვილი");
        public static Client ბესიკითვარაძე = new Client("ბესიკი თვარაძე");
        public static Client ქალდანიგიორგი = new Client("ქალდანი გიორგი");
        public static Client გიორგიქალდანი = new Client("გიორგი ქალდანი");
        public static Client აკაკილობჟანიძე = new Client("აკაკი ლობჟანიძე");
        public static Client გოგაჯინიყაშვილი = new Client("გოგა ჯინიყაშვილი");
        public static Client ბარბაქაძებაკური = new Client("ბარბაქაძე ბაკური");
        public static Client მაღალდაძეზაზა = new Client("მაღალდაძე ზაზა");
        public static Client ნუკრიჯაგუნავა = new Client("ნუკრი ჯაგუნავა");
        public static Client ხორბალაძერობერტი = new Client("ხორბალაძე რობერტი");
        public static Client შოთაბურდული = new Client("შოთა ბურდული");
        public static Client რამისგულიევი = new Client("რამის გულიევი");
        public static Client ჯინორიძექრისტინე = new Client("ჯინორიძე ქრისტინე");
        public static Client ირაკლიზარანდია = new Client("ირაკლი ზარანდია");
        public static Client ზარანდიაირაკლი = new Client("ზარანდია ირაკლი");
        public static Client მაგამედოვიქამილა = new Client("მაგამედოვი ქამილა");
        public static Client ოსმანოვიბახადინ = new Client("ოსმანოვი ბახადინ");
        public static Client კვიწინაძემამუკა = new Client("კვიწინაძე მამუკა");
        public static Client ვიტალიფიფია = new Client("ვიტალი ფიფია");
        public static Client დავითირემაშვილი = new Client("დავით ირემაშვილი");
        public static Client ბესარიონსურმავა = new Client("ბესარიონ სურმავა");
        public static Client ნუგზარგოგოლაშვილი = new Client("ნუგზარ გოგოლაშვილი");
        public static Client ქარდავანათელა = new Client("ქარდავა ნათელა");
        public static Client შოთაშარბანაშვილი = new Client("შოთა შარბანაშვილი ");
        public static Client გიორგიჟღენტი = new Client("გიორგი ჟღენტი");
        public static Client ნინოსოხაშვილი = new Client("ნინო სოხაშვილი");
        public static Client თამაზფერსაშვილი = new Client("თამაზ ფერსაშვილი");
        public static Client მარიამწიკლაური = new Client("მარიამ წიკლაური");
        public static Client საკანდელიძებესარიონ = new Client("საკანდელიძე ბესარიონ");
        public static Client სოფიობლიაძე = new Client("სოფიო ბლიაძე");
        public static Client ბეჭვაიაირაკლი = new Client("ბეჭვაია ირაკლი");
        public static Client თორაძეგიორგი = new Client("თორაძე გიორგი");
        public static Client გოჩამოდებაძე = new Client("გოჩა მოდებაძე");
        public static Client ჯაჯანიძელაშა = new Client("ჯაჯანიძე ლაშა");
        public static Client მიხეილისამხარაძე = new Client("მიხეილი სამხარაძე");
        public static Client ჯუმბერირიჟვაძე = new Client("ჯუმბერი რიჟვაძე");
        public static Client ზაურბერიძე = new Client("ზაურ ბერიძე");
        public static Client როლანდიბოლქვაძე = new Client("როლანდი ბოლქვაძე");
        public static Client დადუნაშვილიგივი = new Client("დადუნაშვილი გივი");
        public static Client ქურთიაშვილიმანანა = new Client("ქურთიაშვილი მანანა");
        public static Client ალბინაალბოროვა = new Client("ალბინა ალბოროვა");
        public static Client ტარიელტაბატაძე = new Client("ტარიელ ტაბატაძე");
        public static Client ვალიშვილითემურ = new Client("ვალიშვილი თემურ");
        public static Client მიხეილკუტუბიძე = new Client("მიხეილ კუტუბიძე");
        public static Client შულაიაგიორგი = new Client("შულაია გიორგი");
        public static Client ილიაკორინთელი = new Client("ილია კორინთელი");
        public static Client ნანაროგავა = new Client("ნანა როგავა");
        public static Client დავითშაინიძე = new Client("დავით შაინიძე");
        public static Client ლევანახალაია = new Client("ლევან ახალაია");
        public static Client ლასხიშვილიგიორგი = new Client("ლასხიშვილი გიორგი");
        public static Client გიორგიგახოკიძე = new Client("გიორგი გახოკიძე ");
        public static Client გახოკიძეგიორგი = new Client("გახოკიძე გიორგი");
        public static Client სვანაძეთამრიკო = new Client("სვანაძე თამრიკო");
        public static Client მალაციძენინო = new Client("მალაციძე ნინო");
        public static Client ჩხიკვაძეგოჩა = new Client("ჩხიკვაძე გოჩა");
        public static Client ვართანიანიგაიანე = new Client("ვართანიანი გაიანე");
        public static Client თეიმურაზლუხუტაშვილი = new Client("თეიმურაზ ლუხუტაშვილი");
        public static Client ბალავაძემარინა = new Client("ბალავაძე მარინა");
        public static Client მიკუჩაძეაკაკი = new Client("მიკუჩაძე აკაკი");
        public static Client გურამგოცაძე = new Client("გურამ გოცაძე");
        public static Client ფარეშიშვილიშოთა = new Client("ფარეშიშვილი შოთა");
        public static Client giorgaZedaviT = new Client("giorgaZe daviT");
        public static Client გოდერძითვაური = new Client("გოდერძი თვაური");
        public static Client ილიადვალი = new Client("ილია დვალი");
        public static Client თამართელია = new Client("თამარ თელია");
        public static Client თეიმურაზჯანიაშვილი = new Client("თეიმურაზ ჯანიაშვილი");
        public static Client ედილაშვილიგულნარა = new Client("ედილაშვილი გულნარა");
        public static Client გიორგიმელქონიანი = new Client("გიორგი მელქონიანი");
        public static Client გაგნიძეგიორგი = new Client("გაგნიძე გიორგი");
        public static Client რომანგოგოლაძე = new Client("რომან გოგოლაძე");
        public static Client ცანკაშვილილია = new Client("ცანკაშვილი ლია");
        public static Client ნიკურაძეგიორგი = new Client("ნიკურაძე გიორგი");
        public static Client გიორგინიკურაძე = new Client("გიორგი ნიკურაძე");
        public static Client თეონაწერეთელი = new Client("თეონა წერეთელი");
        public static Client RAZMAZEGIORGI = new Client("RAZMAZE GIORGI");
        public static Client დათოჩახუნაშვილი = new Client("დათო ჩახუნაშვილი");
        public static Client ჯაბნიძეოთარ = new Client("ჯაბნიძე ოთარ");
        public static Client ბაბალეგაგოშვილი = new Client("ბაბალე გაგოშვილი");
        public static Client გიორგიჯელაძე = new Client("გიორგი ჯელაძე");
        public static Client ყეინაშვილინოდარ = new Client("ყეინაშვილი ნოდარ");
        public static Client ოთარიობაშვილი = new Client("ოთარ იობაშვილი");
        public static Client თოდაძეთორნიკე = new Client("თოდაძე თორნიკე");
        public static Client აბრამიშვილიდავით = new Client("აბრამიშვილი დავით");
        public static Client გივიზვერიაშვილი = new Client("გივი ზვერიაშვილი");
        public static Client ზურაბივანიაშვილი = new Client("ზურაბ ივანიაშვილი");
        public static Client ზურაბნონიაძე = new Client("ზურაბ ნონიაძე");
        public static Client გურბანგარაჯაევი = new Client("გურბან გარაჯაევი");
        public static Client გიაბიწაძე = new Client("გია ბიწაძე");
        public static Client მაისურაძენიკოლოზ = new Client("მაისურაძე ნიკოლოზ");
        public static Client გოჩასიხარულიძე = new Client("გოჩა სიხარულიძე");
        public static Client მზიადარჩიძე = new Client("მზია დარჩიძე");
        public static Client გოგიტიძეილია = new Client("გოგიტიძე ილია");
        public static Client გაბისონიამარინა = new Client("გაბისონია მარინა");
        public static Client ამირანბერუაშვილი = new Client("ამირან ბერუაშვილი");
        public static Client გაგაკოხტაშვილი = new Client("გაგა კოხტაშვილი");
        public static Client მერაბზარიძე = new Client("მერაბ ზარიძე");
        public static Client ნათიასიდამონიძე = new Client("ნათია სიდამონიძე");
        public static Client დოლიძეინგა = new Client("დოლიძე ინგა");
        public static Client რამაზგულიაშვილი = new Client("რამაზ გულიაშვილი");
        public static Client ირაკლიპაიჭაძე = new Client("ირაკლი  პაიჭაძე ");
        public static Client სეხნიაშვილითემურ = new Client("სეხნიაშვილი თემურ");
        public static Client ლედიცინაური = new Client("ლედი ცინაური");
        public static Client გივიალადაშვილი = new Client("გივი ალადაშვილი");
        public static Client ზაზასიჭინავა = new Client("ზაზა სიჭინავა                             ");
        public static Client კობამამინაიშვილი = new Client("კობა მამინაიშვილი");
        public static Client ნიკოლოზჩაფიჩაძე = new Client("ნიკოლოზ ჩაფიჩაძე");
        public static Client მალხაზმჭედლიშვილი = new Client("მალხაზ მჭედლიშვილი");
        public static Client გიორგიჩოხელი = new Client("გიორგი ჩოხელი");
        public static Client იოსებსარალიძე = new Client("იოსებ სარალიძე");
        public static Client რევაზაბრამიშვილი = new Client("რევაზ აბრამიშვილი");
        public static Client კახაბერფაჟავა = new Client("კახაბერ ფაჟავა");
        public static Client ზურაბქურდობაძე = new Client("ზურაბ ქურდობაძე");
        public static Client ყაჩმაზოვითენგიზი = new Client("ყაჩმაზოვი თენგიზი");
        public static Client vefxiSvililaSa = new Client("vefxiSvili laSa");
        public static Client ლევანმეგრელაძე = new Client("ლევან მეგრელაძე");
        public static Client ქეთევანცნობილაძე = new Client("ქეთევან ცნობილაძე");
        public static Client მარინაგელაშვილი = new Client("მარინა გელაშვილი");
        public static Client სხირტლაძეივანე = new Client("სხირტლაძე ივანე");
        public static Client ლაცაბიძეზვიადი = new Client("ლაცაბიძე ზვიადი");
        public static Client კოპაძესოფიკო = new Client("კოპაძე სოფიკო");
        public static Client როსტიაშვილილიანა = new Client("როსტიაშვილი ლიანა");
        public static Client მაკაქათამაძე = new Client("მაკა ქათამაძე ");
        public static Client პავლიაშვილილევან = new Client("პავლიაშვილი ლევან");
        public static Client ხიზანიშვილილაშა = new Client("ხიზანიშვილი ლაშა");
        public static Client მადონანაცვლიშვილი = new Client("მადონა ნაცვლიშვილი");
        public static Client შოშიტაშვილიგიორგი = new Client("შოშიტაშვილი გიორგი");
        public static Client გასანოვინოვრუზ = new Client("გასანოვი ნოვრუზ");
        public static Client სხილაძეზურაბ = new Client("სხილაძე ზურაბ");
        public static Client ივეჩიანიგოგა = new Client("ივეჩიანი გოგა");
        public static Client შაინიძედავით = new Client("შაინიძე დავით");
        public static Client რომანკეკელიძე = new Client("რომან კეკელიძე");
        public static Client ოთარგულიკაშვილი = new Client("ოთარ გულიკაშვილი");
        public static Client გიგაშვილიქრისტინე = new Client("გიგაშვილი ქრისტინე");
        public static Client სალომედავითულიანი = new Client("სალომე დავითულიანი");
        public static Client დავითბულიავა = new Client("დავით ბულიავა");
        public static Client დოდონაჭყებია = new Client("დოდო ნაჭყებია             ");
        public static Client ნანიშელია = new Client("ნანი შელია                                ");
        public static Client ეკატერინექლიბაძე = new Client("ეკატერინე ქლიბაძე              ");
        public static Client აიდინჯავადოვი = new Client("აიდინ ჯავადოვი           ");
        public static Client ზაქარიაძეჯანსულ = new Client("ზაქარიაძე ჯანსულ");
        public static Client თამაზბერიძე = new Client("თამაზ ბერიძე");
        public static Client ბარნაბიშვილითეონა = new Client("ბარნაბიშვილი თეონა");
        public static Client გოჩაკაპანაძე = new Client("გოჩა კაპანაძე                                  ");
        public static Client მაჩიტიძეკობა = new Client("მაჩიტიძე კობა");
        public static Client კრიხელითამარი = new Client("კრიხელი თამარი");
        public static Client გელაჯაბნიძე = new Client("გელა ჯაბნიძე                            ");
        public static Client შალვასუქასოვი = new Client("შალვა სუქასოვი");
        public static Client მარინეგაზაშვილი = new Client("მარინე გაზაშვილი");
        public static Client გიორგიღვალაძე = new Client("გიორგი ღვალაძე");
        public static Client ძიძიგურიზაზა = new Client("ძიძიგური ზაზა");
        public static Client ქოქაშვილიზვიად = new Client("ქოქაშვილი ზვიად");
        public static Client ქაფიანიძედავით = new Client("ქაფიანიძე დავით");
        public static Client რატიავალერიანი = new Client("რატია ვალერიანი");
        public static Client თიგიშვილირობერტი = new Client("თიგიშვილი რობერტი");
        public static Client ბუბუტეიშვილიმამია = new Client("ბუბუტეიშვილი მამია");
        public static Client ციციშვილითაიზი = new Client("ციციშვილი თაიზი");
        public static Client barbaqaZeTamar = new Client("barbaqaZe Tamar");
        public static Client ზაზანოზაძე = new Client("ზაზა ნოზაძე");
        public static Client ხოსიტაშვილიზურაბი = new Client("ხოსიტაშვილი ზურაბი");
        public static Client ხმალაძეანა = new Client("ხმალაძე ანა");
        public static Client ელზახაჭაპურიძე = new Client("ელზა ხაჭაპურიძე                      ");
        public static Client შოთახელაძე = new Client("შოთა ხელაძე");
        public static Client დედალამაზიშვილიდალი = new Client("დედალამაზიშვილი დალი");
        public static Client გიორგიცომაია = new Client("გიორგი ცომაია");
        public static Client პავლიაშვილინუკრი = new Client("პავლიაშვილი ნუკრი");
        public static Client ნატალიაქადაგიძე = new Client("ნატალია ქადაგიძე");
        public static Client ხუციშვილიზაზა = new Client("ხუციშვილი ზაზა");
        public static Client რამაზლაშხია = new Client("რამაზ ლაშხია");
        public static Client ზურაბჩიხელიძე = new Client("ზურაბ ჩიხელიძე");
        public static Client წიქარიშვილინანა = new Client("წიქარიშვილი ნანა");
        public static Client ბეგლარიშვილისოფიკო = new Client("ბეგლარიშვილი სოფიკო");
        public static Client საჩეჩელაშვილიმანანა = new Client("საჩეჩელაშვილი მანანა");
        public static Client გიორგიკაკაშვილი = new Client("გიორგი კაკაშვილი                          ");
        public static Client კუსრაშვილიმიხეილი = new Client("კუსრაშვილი მიხეილი");
        public static Client მიხეილშამოევი = new Client("მიხეილ შამოევი                     ");
        public static Client ვიბლიანიმაკა = new Client("ვიბლიანი მაკა");
        public static Client გაბოძენინელი = new Client("გაბოძე ნინელი");
        public static Client თორნიკეჯოხაძე = new Client("თორნიკე ჯოხაძე                             ");
        public static Client ბენიამინხუსკივაძე = new Client("ბენიამინ ხუსკივაძე              ");
        public static Client იაგუბოვიიფრატ = new Client("იაგუბოვი იფრატ");
        public static Client ჯავახიშვილიდავითი = new Client("ჯავახიშვილი დავითი");
        public static Client ხაჩიძეეკატერინე = new Client("ხაჩიძე ეკატერინე");
        public static Client რუსუდანელიავა = new Client("რუსუდან ელიავა");
        public static Client ქაჯაიაირაკლი = new Client("ქაჯაია ირაკლი");
        public static Client ბაქრაძეგიორგი = new Client("ბაქრაძე გიორგი");
        public static Client ჩალაბაშვილიგიგა = new Client("ჩალაბაშვილი გიგა");
        public static Client მამარიანიმურაზ = new Client("მამარიანი მურაზ");
        public static Client ეთერკორკოტაშვილი = new Client("ეთერ კორკოტაშვილი");
        public static Client ჯანაშვილიზვიადი = new Client("ჯანაშვილი ზვიადი");
        public static Client ჩილაჩავაკობა = new Client("ჩილაჩავა კობა");
        public static Client ოგნაძეინგა = new Client("ოგნაძე ინგა");
        public static Client ფანცხავასოფიო = new Client("ფანცხავა სოფიო");
        public static Client კალანდაძეთემურ = new Client("კალანდაძე თემურ");
        public static Client გრიგალაშვილიცისანა = new Client("გრიგალაშვილი ცისანა");
        public static Client ვიქტორიაპოლოზენკო = new Client("ვიქტორია პოლოზენკო");
        public static Client მათიაშვილინოდარ = new Client("მათიაშვილი ნოდარ");
        public static Client სოფიოდონდუა = new Client("სოფიო დონდუა");
        public static Client ჭოლაძემანანა = new Client("ჭოლაძე მანანა");
        public static Client ინეზაჯაბუა = new Client("ინეზა ჯაბუა                             ");
        public static Client ანაყავლაშვილი = new Client("ანა ყავლაშვილი");
        public static Client არაბულიმამუკა = new Client("არაბული მამუკა");
        public static Client ფურცხვანიძესოფიო = new Client("ფურცხვანიძე სოფიო");
        public static Client ბექაცერცვაძე = new Client("ბექა ცერცვაძე");
        public static Client გიორგიბეროშვილი = new Client("გიორგი ბეროშვილი");
        public static Client გურჩიანივიქტორია = new Client("გურჩიანი ვიქტორია");
        public static Client იმერლიშვილიმარინე = new Client("იმერლიშვილი მარინე");
        public static Client ხიზანიშვილიგვანცა = new Client("ხიზანიშვილი გვანცა");
        public static Client კალატოზიშვილიქეთევანი = new Client("კალატოზიშვილი ქეთევანი");
        public static Client ლავრენტლასარეიშვილი = new Client("ლავრენტ ლასარეიშვილი        ");
        public static Client დავითსახვაძე = new Client("დავით სახვაძე                                         ");
        public static Client გამრეკელითამარ = new Client("გამრეკელი თამარ");
        public static Client ტეფნაძეთეონა = new Client("ტეფნაძე თეონა");
        public static Client ჭანტურიძეთეიმურაზ = new Client("ჭანტურიძე თეიმურაზ");
        public static Client ჩინჩახაშვილითამარი = new Client("ჩინჩახაშვილი თამარი");
        public static Client გელაშვილიკობა = new Client("გელაშვილი კობა");
        public static Client იუზათედეევა = new Client("იუზა თედეევა");
        public static Client იმედამიქელაძე = new Client("იმედა მიქელაძე");
        public static Client boWoriSvilimamuka = new Client("boWoriSvili mamuka");
        public static Client უნგიაძეირინა = new Client("უნგიაძე ირინა");
        public static Client სულხანიშვილიგიორგი = new Client("სულხანიშვილი გიორგი");
        public static Client ანზორიხუციძე = new Client("ანზორი ხუციძე");
        public static Client ინაელიბეკოვა = new Client("ინა ელიბეკოვა");
        public static Client ვანობებუთაშვილი = new Client("ვანო ბებუთაშვილი");
        public static Client აკაკირუაძე = new Client("აკაკი რუაძე");
        public static Client ლევანგაგნიძე = new Client("ლევან გაგნიძე");
        public static Client დავითცერცვაძე = new Client("დავით ცერცვაძე");
        public static Client ნიკოლოზინასარიძე = new Client("ნიკოლოზ ინასარიძე");
        public static Client ჯუმბერშუბითიძე = new Client("ჯუმბერ შუბითიძე");
        public static Client დავითმაჭარაშვილი = new Client("დავით მაჭარაშვილი");
        public static Client დავითჭინჭარაული = new Client("დავით ჭინჭარაული");
        public static Client ძაძამიათენგიზ = new Client("ძაძამია თენგიზ");
        public static Client ნიკოლეიშვილითეოფანე = new Client("ნიკოლეიშვილი თეოფანე");
        public static Client რობიკოვაზაგაშვილი = new Client("რობიკო ვაზაგაშვილი");
        public static Client ქავთარაძემირიან = new Client("ქავთარაძე მირიან");
        public static Client კირაკოსიანირაფაელი = new Client("კირაკოსიანი რაფაელი");
        public static Client გაბაძეკარინა = new Client("გაბაძე კარინა");
        public static Client მამედოვიიოლჩი = new Client("მამედოვი იოლჩი");
        public static Client გილაურიდავით = new Client("გილაური დავით");
        public static Client შიშნიაშვილიდიმიტრი = new Client("შიშნიაშვილი დიმიტრი");
        public static Client ალექსანიანიმიხეილ = new Client("ალექსანიანი მიხეილ");
    }
}