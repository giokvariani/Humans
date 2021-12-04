using System.Collections.Generic;
using System.Linq;
using System;

namespace Training
{
    public static class Database
    {
        public static List<Human> Humans = new[]
        {
            Human.ჯიქიაგიორგი,
            Human.გოგოლაძებადრი,
            Human.გიორგისირბილაშვილი,
            Human.ფიქრიაბუბუნაური,
            Human.ნათიაბიწკინაშვილი,
            Human.გოჩაბერიძე,
            Human.ჯალაბაძეგიორგი,
            Human.ჯალაბაძეგიორგი,
            Human.ფერდინანტიმაღლაკელიძე,
            Human.ჯიქიაგიორგი,
            Human.ცერცვაძეანანო,
            Human.ბექასაჯაია,
            Human.ბექასაჯაია,
            Human.აშრალოვიიჯრან,
            Human.ხარჩილავაბადრი,
            Human.ესართიაელგუჯა,
            Human.ჩხობაძედავით,
            Human.აკაკიჯანჯღავა,
            Human.ჯანჯღავააკაკი,
            Human.სხირტლაძეკახაბერ,
            Human.სიმონიშვილიმაკა,
            Human.კოსმანანტონ,
            Human.ელისაშვილიქეთევან,
            Human.ყიფიანილელა,
            Human.ჯოხაძენიკოლოზი,
            Human.ნიკოლაიშვილიშალვა,
            Human.ქავთარაძელაშა,
            Human.ბედოიძეპავლე,
            Human.კუკავათათია,
            Human.ამირანღორჯომელაძე,
            Human.ღორჯომელაძეამირან,
            Human.ქიტიაშვილიდავით,
            Human.მარიდრიუკოვა,
            Human.დრიუკოვამარი,
            Human.ლევანხასაია,
            Human.დვალიირაკლი,
            Human.მებაღიშვილიციური,
            Human.აგურაშვილიქეთევან,
            Human.კუპრეიშვილიბექა,
            Human.ბუსკივაძებაჩუკი,
            Human.გოგოლაძებადრი,
            Human.ნარსიაინდირა,
            Human.ხუნჯუაჯუმბერი,
            Human.ფარჯიანიზურიკო,
            Human.უფლისაშვილიირაკლი,
            Human.სახოკიაზაზა,
            Human.სახოკიაზაზა,
            Human.წულაიავლადიმერი,
            Human.ხუროშვილიალექსანდრე,
            Human.ოდილავაძეგიორგი,
            Human.მამედოვიელხან,
            Human.დავითაძეროინ,
            Human.ჩუთლაშვილიკორნელი,
            Human.პაპისმედოვირუბენი,
            Human.დავითაძეროინ,
            Human.შენგელიალელა,
            Human.ჯალიაშვილილია,
            Human.გვანცელაძეთამარი,
            Human.თემურმეკეიძე,
            Human.მელიქიშვილიდავით,
            Human.გურამთარაშვილი,
            Human.კიაზოკაპანაძე,
            Human.ოთარიბიკაშვილი,
            Human.გელაგაბელაია,
            Human.თამარაოვანესიანი,
            Human.პლატონშვანგირაძე,
            Human.ბაქიევიარიზ,
            Human.ქუჯიტაბაღუა,
            Human.გიორგიმაკარაძე,
            Human.ხაჩიკიანიედუარდ,
            Human.ტატუაშვილილაშა,
            Human.ხითარიშვილიგიორგი,
            Human.კუკავაკარინა,
            Human.ჩხეიძერომეო,
            Human.ფიფიაზაალ,
            Human.შალვაპატურაშვილი,
            Human.პატურაშვილიშალვა,
            Human.გასანოვიათამ,
            Human.ჯაჯანიძეგიორგი,
            Human.კარაპეტოვითენგიზ,
            Human.შანავაგიორგი,
            Human.თენგიზკარაპეტოვი,
            Human.კოღერაშვილიგოჩა,
            Human.ჩაკვეტაძეგიორგი,
            Human.ლომიძეთათია,
            Human.ხოშორაძემელანო,
            Human.ინასარიძებადრი,
            Human.ზაუტაშვილიპაატა,
            Human.გივრაძელევან,
            Human.მიხეილილიქოკელი,
            Human.ბუნტურივასილ,
            Human.მირიანიკაპანაძე,
            Human.გურბანგამიდოვი,
            Human.უსოევიმიხეილ,
            Human.ჟორდანიაზვიად,
            Human.ლუცუფიძეგიორგი,
            Human.კოკოზაშვილიგიორგი,
            Human.ცერცვაძეანანო,
            Human.გოჩოლეიშვილიგიორგი,
            Human.გოჩოლეიშვილიგიორგი,
            Human.მოსიათამთა,
            Human.ჩიტიშვილიმიხეილ,
            Human.გახოკიაბაჩუკი,
            Human.ბიბილეიშვილიირინა,
            Human.ბარამიძეშაკო,
            Human.ჯიოევიზურაბ,
            Human.შიანოვგიორგი,
            Human.შიანოვგიორგი,
            Human.გოდიშვილიმალხაზ,
            Human.საჯაიარამაზ,
            Human.ანაშონია,
            Human.შონიაანა,
            Human.მაისურაძეგია,
            Human.მაისურაძეგია,
            Human.მაისურაძეგია,
            Human.მაისურაძეგია,
            Human.ლევანბერძენიშვილი,
            Human.ლევანბერძენიშვილი,
            Human.ლევანბერძენიშვილი,
            Human.ლევანბერძენიშვილი,
            Human.ჯორბენაძენანა,
            Human.ჯორბენაძენანა,
            Human.მსხვილიძეამირან,
            Human.ეიბოვიბრაგიმ,
            Human.საჯაიარამაზ,
            Human.შუბითიძეჯემალი,
            Human.ზვიადბელაუსოვი,
            Human.ბელაუსოვიზვიად,
            Human.ქვირიამიხეილ,
            Human.ირაკლიდუნდუა,
            Human.ხაჩიძეხვიჩა,
            Human.გასანოვითამაზ,
            Human.ლევანგუჯაბიძე,
            Human.ფეიქრიშვილიგიორგი,
            Human.ფეიქრიშვილიგიორგი,
            Human.გიაწაველიძე,
            Human.გადელიაგიორგი,
            Human.კუპატაძენაირა,
            Human.გიორგიჩხეიძე,
            Human.გიორგიგადელია,
            Human.ზაქროსახიაშვილი,
            Human.მიქაძეკახაბერ,
            Human.იაკობიშვილიირაკლი,
            Human.გიორგიმაღალდაძე,
            Human.გიორგიმაღალდაძე,
            Human.ამონაშვილიზვიადი,
            Human.ბეჟანჯინჭარაძე,
            Human.მერაბპაპასკუა,
            Human.ვასილკურტანიძე,
            Human.თორნიკეკაპანაძე,
            Human.ათაბაგილიანა,
            Human.ჩაბრაძეშაქრო,
            Human.ჯემალალოიანი,
            Human.ალოიანიჯემალ,
            Human.ამირანფეტვიაშვილი,
            Human.გვაჯაიათენგიზ,
            Human.მაღრაძელევანი,
            Human.პაპიძეემზარ,
            Human.ქუთათელაძეგიორგი,
            Human.ჯანელიძეალეკო,
            Human.ისაევაალვინა,
            Human.ბალხამიშვილიმაია,
            Human.ალბოროვაჟანა,
            Human.ზაქარიაყალაყაშვილი,
            Human.ბესიკითვარაძე,
            Human.ქალდანიგიორგი,
            Human.გიორგიქალდანი,
            Human.აკაკილობჟანიძე,
            Human.გოგაჯინიყაშვილი,
            Human.ბარბაქაძებაკური,
            Human.მაღალდაძეზაზა,
            Human.ნუკრიჯაგუნავა,
            Human.ხორბალაძერობერტი,
            Human.შოთაბურდული,
            Human.რამისგულიევი,
            Human.ჯინორიძექრისტინე,
            Human.ირაკლიზარანდია,
            Human.ზარანდიაირაკლი,
            Human.ზარანდიაირაკლი,
            Human.მაგამედოვიქამილა,
            Human.ოსმანოვიბახადინ,
            Human.კვიწინაძემამუკა,
            Human.ქალდანიგიორგი,
            Human.ვიტალიფიფია,
            Human.დავითირემაშვილი,
            Human.ბესარიონსურმავა,
            Human.ნუგზარგოგოლაშვილი,
            Human.ქარდავანათელა,
            Human.შოთაშარბანაშვილი,
            Human.გიორგიჟღენტი,
            Human.ნინოსოხაშვილი,
            Human.თამაზფერსაშვილი,
            Human.მარიამწიკლაური,
            Human.საკანდელიძებესარიონ,
            Human.სოფიობლიაძე,
            Human.ბეჭვაიაირაკლი,
            Human.თორაძეგიორგი,
            Human.გოჩამოდებაძე,
            Human.გოჩამოდებაძე,
            Human.ჯაჯანიძელაშა,
            Human.ბედოიძეპავლე,
            Human.შენგელიალელა,
            Human.ლიკახიდაშელი,
            Human.სოფიოჟვანია,
            Human.მეგიბეროძე,
            Human.ლომერახალაია,
            Human.მადონალორთქიფანიძე,
            Human.რამაზსამყურაშვილი,
            Human.იზოლდაგოგბერაშვილი,
            Human.კობანოზაძე,
            Human.გოჩალაზარიშვილი,
            Human.ჯამბურიძეიზოლდა,
            Human.სოლომნიშვილილეილა,
            Human.ზვიადმუსერიძე,
            Human.გაგუაელენე,
            Human.გორჯელაძერამაზ,
            Human.ჩაკვეტაძეშალვა,
            Human.ბოლაშვილიზურაბ,
            Human.ბიგვავადალი,
            Human.ილიაკოტაშვილი,
            Human.ნუცუბიძენესტანი,
            Human.გუსეინოვიაბას,
            Human.მიხეილგურჯიძე,
            Human.ტურაშვილინანა,
            Human.მებაღიშვილიელიზა,
            Human.აბბასოვისალეჰ,
            Human.ივანიკაშვილიმიხეილ,
            Human.მსხვილიძედარინა,
            Human.ლოთუაშვილიოთარ,
            Human.ხვიჩაბერიძე,
            Human.ნიკოლოზიმეისრიშვილი,
            Human.სოხაძედავით,
            Human.ლოხიაურიდავით,
            Human.ალხანაიძეგოჩა,
            Human.უსტარაშვილინათია,
            Human.ნუფტულაევიადილ,
            Human.დავითოქროპირიძე,
            Human.ნონამანიჟაშვილი,
            Human.ჩაჩიბაიადავით,
            Human.ჭრელაშვილიარჩილ,
            Human.მაძღარაშვილიგელა,
            Human.კიტრიაშვილისულიკო,
            Human.ჯანეზაშვილიაბესალომ,
            Human.გაგლოევიზაზა,
            Human.ვალერიანგვიშიანი,
            Human.მიხეილბოღოლაშვილი,
            Human.ტყეშელაშვილიავთანდილ,
            Human.ბაინდურაშვილიალექსანდრე,
            Human.გელამამულაშვილი,
            Human.გოგოხიაკახაბერ,
            Human.კუხიანიძედავითი,
            Human.გოგაკუხალეიშვილი,
            Human.ილიაგოგეშვილი,
            Human.ზურაბაბშილავა,
            Human.გვალიაპაატა,
            Human.იმნაძედავით,
            Human.ბარამიძეკახა,
            Human.კალანდაძემადლენა,
            Human.კონწლიაშვილიიოსებ,
            Human.ლევანშავგულიძე,
            Human.მინდიაპაკელიანია,
            Human.ნათიკკასანოვი,
            Human.გიორგიმილაძე,
            Human.ძიძიშვილიბესიკ,
            Human.ბლიაძელია,
            Human.კონსტანტინემეგრელიშვილი,
            Human.მიხეილქურციკიძე,
            Human.მირზამირაზანაშვილი,
            Human.ლაშაალანია,
            Human.ვაჟაქავთარაძე,
            Human.პაქსაძეემზარ,
            Human.იზაბელასახოკია,
            Human.წიწიკაშვილიზაზა,
            Human.რომანიხატისაშვილი,
            Human.სორდიალიკა,
            Human.გაბედავაიზა,
            Human.გიორგისაამიშვილი,
            Human.გიორგისაამიშვილი,
            Human.ბეჟანიპაპიაშვილი,
            Human.ბეჟანიპაპიაშვილი,
            Human.ირმამჟავანაძე,
            Human.ირმამჟავანაძე,
            Human.ირმამჟავანაძე,
            Human.ეკაოსიშვილი,
            Human.გიზოაბდუშელიძე,
            Human.მიხეილისამხარაძე,
            Human.მიხეილისამხარაძე,
            Human.ჯუმბერირიჟვაძე,
            Human.ზაურბერიძე,
            Human.როლანდიბოლქვაძე,
            Human.დადუნაშვილიგივი,
            Human.ქურთიაშვილიმანანა,
            Human.ალბინაალბოროვა,
            Human.ტარიელტაბატაძე,
            Human.ვალიშვილითემურ,
            Human.მიხეილკუტუბიძე,
            Human.შულაიაგიორგი,
            Human.ილიაკორინთელი,
            Human.ნანაროგავა,
            Human.დავითშაინიძე,
            Human.ლევანახალაია,
            Human.ჯალიაშვილილია,
            Human.ლასხიშვილიგიორგი,
            Human.ლასხიშვილიგიორგი,
            Human.გიორგიგახოკიძე,
            Human.გახოკიძეგიორგი,
            Human.გახოკიძეგიორგი,
            Human.სვანაძეთამრიკო,
            Human.მალაციძენინო,
            Human.ჩხიკვაძეგოჩა,
            Human.ვართანიანიგაიანე,
            Human.თეიმურაზლუხუტაშვილი,
            Human.ბალავაძემარინა,
            Human.მიკუჩაძეაკაკი,
            Human.გურამგოცაძე,
            Human.ფარეშიშვილიშოთა,
            Human.giorgaZedaviT,
            Human.გოდერძითვაური,
            Human.ილიადვალი,
            Human.თამართელია,
            Human.თეიმურაზჯანიაშვილი,
            Human.ედილაშვილიგულნარა,
            Human.გიორგიმელქონიანი,
            Human.გაგნიძეგიორგი,
            Human.რომანგოგოლაძე,
            Human.ცანკაშვილილია,
            Human.ნიკურაძეგიორგი,
            Human.გიორგინიკურაძე,
            Human.თეონაწერეთელი,
            Human.RAZMAZEGIORGI,
            Human.დათოჩახუნაშვილი,
            Human.ჯაბნიძეოთარ,
            Human.ბაბალეგაგოშვილი,
            Human.გიორგიჯელაძე,
            Human.ყეინაშვილინოდარ,
            Human.ყეინაშვილინოდარ,
            Human.გიორგიკაკაშვილი,
            Human.ოთარიობაშვილი,
            Human.თოდაძეთორნიკე,
            Human.აბრამიშვილიდავით,
            Human.გივიზვერიაშვილი,
            Human.ზურაბივანიაშვილი,
            Human.ზურაბივანიაშვილი,
            Human.ზურაბნონიაძე,
            Human.ზურაბნონიაძე,
            Human.გურბანგარაჯაევი,
            Human.გიაბიწაძე,
            Human.მაისურაძენიკოლოზ,
            Human.გოჩასიხარულიძე,
            Human.მზიადარჩიძე,
            Human.მზიადარჩიძე,
            Human.გოგიტიძეილია,
            Human.გაბისონიამარინა,
            Human.ამირანბერუაშვილი,
            Human.გაბისონიამარინა,
            Human.გაგაკოხტაშვილი,
            Human.გაგაკოხტაშვილი,
            Human.მერაბზარიძე,
            Human.მერაბზარიძე,
            Human.ნათიასიდამონიძე,
            Human.ნათიასიდამონიძე,
            Human.დოლიძეინგა,
            Human.რამაზგულიაშვილი,
            Human.ირაკლიპაიჭაძე,
            Human.სეხნიაშვილითემურ,
            Human.სეხნიაშვილითემურ,
            Human.ლედიცინაური,
            Human.ლედიცინაური,
            Human.გივიალადაშვილი,
            Human.ზაზასიჭინავა,
            Human.ზაზასიჭინავა,
            Human.კობამამინაიშვილი,
            Human.ნიკოლოზჩაფიჩაძე,
            Human.ტარიელტაბატაძე,
            Human.მალხაზმჭედლიშვილი,
            Human.გიორგიჩოხელი,
            Human.იოსებსარალიძე,
            Human.რევაზაბრამიშვილი,
            Human.რევაზაბრამიშვილი,
            Human.კახაბერფაჟავა,
            Human.ზურაბქურდობაძე,
            Human.ყაჩმაზოვითენგიზი,
            Human.vefxiSvililaSa,
            Human.ლევანმეგრელაძე,
            Human.ქეთევანცნობილაძე,
            Human.მარინაგელაშვილი,
            Human.სხირტლაძეივანე,
            Human.ლაცაბიძეზვიადი,
            Human.კოპაძესოფიკო,
            Human.როსტიაშვილილიანა,
            Human.პავლიაშვილილევან,
            Human.ხიზანიშვილილაშა,
            Human.მაისურაძენიკოლოზ,
            Human.მადონანაცვლიშვილი,
            Human.შოშიტაშვილიგიორგი,
            Human.გასანოვინოვრუზ,
            Human.სხილაძეზურაბ,
            Human.ივეჩიანიგოგა,
            Human.შაინიძედავით,
            Human.რომანკეკელიძე,
            Human.ოთარგულიკაშვილი,
            Human.გიგაშვილიქრისტინე,
            Human.სალომედავითულიანი,
            Human.დავითბულიავა,
            Human.დოდონაჭყებია,
            Human.ნანიშელია,
            Human.ეკატერინექლიბაძე,
            Human.აიდინჯავადოვი,
            Human.ზაქარიაძეჯანსულ,
            Human.თამაზბერიძე,
            Human.ბარნაბიშვილითეონა,
            Human.გოჩაკაპანაძე,
            Human.მაჩიტიძეკობა,
            Human.კრიხელითამარი,
            Human.გელაჯაბნიძე,
            Human.შალვასუქასოვი,
            Human.მარინეგაზაშვილი,
            Human.მარინეგაზაშვილი,
            Human.გიორგიღვალაძე,
            Human.ძიძიგურიზაზა,
            Human.ქოქაშვილიზვიად,
            Human.ქაფიანიძედავით,
            Human.რატიავალერიანი,
            Human.რატიავალერიანი,
            Human.თიგიშვილირობერტი,
            Human.ბუბუტეიშვილიმამია,
            Human.ციციშვილითაიზი,
            Human.barbaqaZeTamar,
            Human.ზაზანოზაძე,
            Human.ხოსიტაშვილიზურაბი,
            Human.ხმალაძეანა,
            Human.ელზახაჭაპურიძე,
            Human.შოთახელაძე,
            Human.დედალამაზიშვილიდალი,
            Human.გიორგიცომაია,
            Human.პავლიაშვილინუკრი,
            Human.ილიაკორინთელი,
            Human.ნატალიაქადაგიძე,
            Human.ხუციშვილიზაზა,
            Human.რამაზლაშხია,
            Human.ზურაბჩიხელიძე,
            Human.წიქარიშვილინანა,
            Human.ბეგლარიშვილისოფიკო,
            Human.საჩეჩელაშვილიმანანა,
            Human.გიორგიკაკაშვილი,
            Human.კუსრაშვილიმიხეილი,
            Human.მიხეილშამოევი,
            Human.ვიბლიანიმაკა,
            Human.გაბოძენინელი,
            Human.თორნიკეჯოხაძე,
            Human.ბენიამინხუსკივაძე,
            Human.იაგუბოვიიფრატ,
            Human.ჯავახიშვილიდავითი,
            Human.ხაჩიძეეკატერინე,
            Human.რუსუდანელიავა,
            Human.ქაჯაიაირაკლი,
            Human.ბაქრაძეგიორგი,
            Human.ჩალაბაშვილიგიგა,
            Human.მამარიანიმურაზ,
            Human.ეთერკორკოტაშვილი,
            Human.ეთერკორკოტაშვილი,
            Human.ეთერკორკოტაშვილი,
            Human.ჯანაშვილიზვიადი,
            Human.ჯანაშვილიზვიადი,
            Human.ჩილაჩავაკობა,
            Human.ოგნაძეინგა,
            Human.ფანცხავასოფიო,
            Human.კალანდაძეთემურ,
            Human.გრიგალაშვილიცისანა,
            Human.ვიქტორიაპოლოზენკო,
            Human.მათიაშვილინოდარ,
            Human.სოფიოდონდუა,
            Human.ჭოლაძემანანა,
            Human.ინეზაჯაბუა,
            Human.ანაყავლაშვილი,
            Human.არაბულიმამუკა,
            Human.ჭოლაძემანანა,
            Human.ფურცხვანიძესოფიო,
            Human.ბექაცერცვაძე,
            Human.ვიქტორიაპოლოზენკო,
            Human.გიორგიბეროშვილი,
            Human.გურჩიანივიქტორია,
            Human.იმერლიშვილიმარინე,
            Human.იმერლიშვილიმარინე,
            Human.ხიზანიშვილიგვანცა,
            Human.კალატოზიშვილიქეთევანი,
            Human.ლავრენტლასარეიშვილი,
            Human.დავითსახვაძე,
            Human.გამრეკელითამარ,
            Human.ტეფნაძეთეონა,
            Human.ჭანტურიძეთეიმურაზ,
            Human.ჩინჩახაშვილითამარი,
            Human.გელაშვილიკობა,
            Human.იაკობიშვილიირაკლი,
            Human.იუზათედეევა,
            Human.იმედამიქელაძე,
            Human.boWoriSvilimamuka,
            Human.უნგიაძეირინა,
            Human.სულხანიშვილიგიორგი,
            Human.ანზორიხუციძე,
            Human.ინაელიბეკოვა,
            Human.ინაელიბეკოვა,
            Human.ვანობებუთაშვილი,
            Human.აკაკირუაძე,
            Human.ლევანგაგნიძე,
            Human.დავითცერცვაძე,
            Human.ნიკოლოზინასარიძე,
            Human.ჯუმბერშუბითიძე,
        }.ToList();
    }

    public class Human
    {
        public Human(string fullName)
        {
            FullName = fullName;
            FirstName = GetFirstName();
            LastName = GetLastName();

        }

        public string FullName { get; }
        public string FirstName { get ;  }
        public string LastName { get;  }

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


        public static Human ჯიქიაგიორგი = new Human("ჯიქია გიორგი");
        public static Human გიორგისირბილაშვილი = new Human("გიორგი სირბილაშვილი");
        public static Human ფიქრიაბუბუნაური = new Human("ფიქრია ბუბუნაური");
        public static Human ნათიაბიწკინაშვილი = new Human("ნათია ბიწკინაშვილი");
        public static Human გოჩაბერიძე = new Human("გოჩა ბერიძე");
        public static Human ჯალაბაძეგიორგი = new Human("ჯალაბაძე გიორგი");
        public static Human ფერდინანტიმაღლაკელიძე = new Human("ფერდინანტი მაღლაკელიძე");
        public static Human ცერცვაძეანანო = new Human("ცერცვაძე ანანო");
        public static Human ბექასაჯაია = new Human("ბექა საჯაია");
        public static Human აშრალოვიიჯრან = new Human("აშრალოვი იჯრან");
        public static Human ხარჩილავაბადრი = new Human("ხარჩილავა ბადრი");
        public static Human ესართიაელგუჯა = new Human("ესართია ელგუჯა");
        public static Human ჩხობაძედავით = new Human("ჩხობაძე დავით");
        public static Human აკაკიჯანჯღავა = new Human("აკაკი ჯანჯღავა");
        public static Human ჯანჯღავააკაკი = new Human("ჯანჯღავა აკაკი");
        public static Human სხირტლაძეკახაბერ = new Human("სხირტლაძე კახაბერ");
        public static Human სიმონიშვილიმაკა = new Human("სიმონიშვილი მაკა");
        public static Human კოსმანანტონ = new Human("კოსმან ანტონ");
        public static Human ელისაშვილიქეთევან = new Human("ელისაშვილი ქეთევან");
        public static Human ყიფიანილელა = new Human("ყიფიანი ლელა");
        public static Human ჯოხაძენიკოლოზი = new Human("ჯოხაძე ნიკოლოზი");
        public static Human ნიკოლაიშვილიშალვა = new Human("ნიკოლაიშვილი შალვა");
        public static Human ქავთარაძელაშა = new Human("ქავთარაძე ლაშა");
        public static Human კუკავათათია = new Human("კუკავა თათია");
        public static Human ამირანღორჯომელაძე = new Human("ამირან ღორჯომელაძე");
        public static Human ღორჯომელაძეამირან = new Human("ღორჯომელაძე ამირან");
        public static Human ქიტიაშვილიდავით = new Human("ქიტიაშვილი დავით");
        public static Human მარიდრიუკოვა = new Human("მარი დრიუკოვა");
        public static Human დრიუკოვამარი = new Human("დრიუკოვა მარი");
        public static Human ლევანხასაია = new Human("ლევან ხასაია");
        public static Human დვალიირაკლი = new Human("დვალი ირაკლი");
        public static Human მებაღიშვილიციური = new Human("მებაღიშვილი ციური");
        public static Human აგურაშვილიქეთევან = new Human("აგურაშვილი ქეთევან");
        public static Human კუპრეიშვილიბექა = new Human("კუპრეიშვილი ბექა");
        public static Human ბუსკივაძებაჩუკი = new Human("ბუსკივაძე ბაჩუკი");
        public static Human გოგოლაძებადრი = new Human("გოგოლაძე ბადრი");
        public static Human ნარსიაინდირა = new Human("ნარსია ინდირა");
        public static Human ხუნჯუაჯუმბერი = new Human("ხუნჯუა ჯუმბერი");
        public static Human ფარჯიანიზურიკო = new Human("ფარჯიანი ზურიკო");
        public static Human უფლისაშვილიირაკლი = new Human("უფლისაშვილი ირაკლი");
        public static Human სახოკიაზაზა = new Human("სახოკია ზაზა");
        public static Human წულაიავლადიმერი = new Human("წულაია ვლადიმერი");
        public static Human ხუროშვილიალექსანდრე = new Human("ხუროშვილი ალექსანდრე");
        public static Human ოდილავაძეგიორგი = new Human("ოდილავაძე გიორგი");
        public static Human მამედოვიელხან = new Human("მამედოვი ელხან");
        public static Human ჩუთლაშვილიკორნელი = new Human("ჩუთლაშვილი კორნელი");
        public static Human პაპისმედოვირუბენი = new Human("პაპისმედოვი რუბენი");
        public static Human დავითაძეროინ = new Human("დავითაძე როინ");
        public static Human შენგელიალელა = new Human("შენგელია ლელა");
        public static Human ჯალიაშვილილია = new Human("ჯალიაშვილი ლია");
        public static Human გვანცელაძეთამარი = new Human("გვანცელაძე თამარი");
        public static Human თემურმეკეიძე = new Human("თემურ მეკეიძე");
        public static Human მელიქიშვილიდავით = new Human("მელიქიშვილი დავით");
        public static Human გურამთარაშვილი = new Human("გურამ თარაშვილი");
        public static Human კიაზოკაპანაძე = new Human("კიაზო კაპანაძე");
        public static Human ოთარიბიკაშვილი = new Human("ოთარი ბიკაშვილი");
        public static Human გელაგაბელაია = new Human("გელა გაბელაია");
        public static Human თამარაოვანესიანი = new Human("თამარა ოვანესიანი");
        public static Human პლატონშვანგირაძე = new Human("პლატონ შვანგირაძე");
        public static Human ბაქიევიარიზ = new Human("ბაქიევი არიზ");
        public static Human ქუჯიტაბაღუა = new Human("ქუჯი ტაბაღუა");
        public static Human გიორგიმაკარაძე = new Human("გიორგი მაკარაძე");
        public static Human ხაჩიკიანიედუარდ = new Human("ხაჩიკიანი ედუარდ");
        public static Human ტატუაშვილილაშა = new Human("ტატუაშვილი ლაშა");
        public static Human ხითარიშვილიგიორგი = new Human("ხითარიშვილი გიორგი");
        public static Human კუკავაკარინა = new Human("კუკავა კარინა");
        public static Human ჩხეიძერომეო = new Human("ჩხეიძე რომეო");
        public static Human ფიფიაზაალ = new Human("ფიფია ზაალ");
        public static Human შალვაპატურაშვილი = new Human("შალვა პატურაშვილი");
        public static Human პატურაშვილიშალვა = new Human("პატურაშვილი შალვა");
        public static Human გასანოვიათამ = new Human("გასანოვი ათამ");
        public static Human ჯაჯანიძეგიორგი = new Human("ჯაჯანიძე გიორგი");
        public static Human კარაპეტოვითენგიზ = new Human("კარაპეტოვი თენგიზ");
        public static Human შანავაგიორგი = new Human("შანავა გიორგი");
        public static Human თენგიზკარაპეტოვი = new Human("თენგიზ კარაპეტოვი");
        public static Human კოღერაშვილიგოჩა = new Human("კოღერაშვილი გოჩა");
        public static Human ჩაკვეტაძეგიორგი = new Human("ჩაკვეტაძე გიორგი");
        public static Human ლომიძეთათია = new Human("ლომიძე თათია");
        public static Human ხოშორაძემელანო = new Human("ხოშორაძე მელანო");
        public static Human ინასარიძებადრი = new Human("ინასარიძე ბადრი");
        public static Human ზაუტაშვილიპაატა = new Human("ზაუტაშვილი პაატა");
        public static Human გივრაძელევან = new Human("გივრაძე ლევან");
        public static Human მიხეილილიქოკელი = new Human("მიხეილი ლიქოკელი");
        public static Human ბუნტურივასილ = new Human("ბუნტური ვასილ");
        public static Human მირიანიკაპანაძე = new Human("მირიანი კაპანაძე");
        public static Human გურბანგამიდოვი = new Human("გურბან გამიდოვი");
        public static Human უსოევიმიხეილ = new Human("უსოევი მიხეილ");
        public static Human ჟორდანიაზვიად = new Human("ჟორდანია ზვიად");
        public static Human ლუცუფიძეგიორგი = new Human("ლუცუფიძე გიორგი");
        public static Human კოკოზაშვილიგიორგი = new Human("კოკოზაშვილი გიორგი");
        public static Human გოჩოლეიშვილიგიორგი = new Human("გოჩოლეიშვილი გიორგი");
        public static Human მოსიათამთა = new Human("მოსია თამთა");
        public static Human ჩიტიშვილიმიხეილ = new Human("ჩიტიშვილი მიხეილ");
        public static Human გახოკიაბაჩუკი = new Human("გახოკია ბაჩუკი");
        public static Human ბიბილეიშვილიირინა = new Human("ბიბილეიშვილი ირინა");
        public static Human ბარამიძეშაკო = new Human("ბარამიძე შაკო");
        public static Human ჯიოევიზურაბ = new Human("ჯიოევი ზურაბ");
        public static Human შიანოვგიორგი = new Human("შიანოვ გიორგი");
        public static Human გოდიშვილიმალხაზ = new Human("გოდიშვილი მალხაზ");
        public static Human საჯაიარამაზ = new Human("საჯაია რამაზ");
        public static Human ანაშონია = new Human("ანა შონია");
        public static Human შონიაანა = new Human("შონია ანა");
        public static Human მაისურაძეგია = new Human("მაისურაძე გია");
        public static Human ლევანბერძენიშვილი = new Human("ლევან ბერძენიშვილი");
        public static Human ჯორბენაძენანა = new Human("ჯორბენაძე ნანა");
        public static Human მსხვილიძეამირან = new Human("მსხვილიძე ამირან");
        public static Human ეიბოვიბრაგიმ = new Human("ეიბოვ იბრაგიმ");
        public static Human შუბითიძეჯემალი = new Human("შუბითიძე ჯემალი");
        public static Human ზვიადბელაუსოვი = new Human("ზვიად ბელაუსოვი  ");
        public static Human ბელაუსოვიზვიად = new Human("ბელაუსოვი ზვიად");
        public static Human ქვირიამიხეილ = new Human("ქვირია მიხეილ");
        public static Human ირაკლიდუნდუა = new Human("ირაკლი დუნდუა");
        public static Human ხაჩიძეხვიჩა = new Human("ხაჩიძე ხვიჩა");
        public static Human გასანოვითამაზ = new Human("გასანოვი თამაზ");
        public static Human ლევანგუჯაბიძე = new Human("ლევან გუჯაბიძე");
        public static Human ფეიქრიშვილიგიორგი = new Human("ფეიქრიშვილი გიორგი");
        public static Human გიაწაველიძე = new Human("გია წაველიძე");
        public static Human გადელიაგიორგი = new Human("გადელია გიორგი");
        public static Human კუპატაძენაირა = new Human("კუპატაძე ნაირა");
        public static Human გიორგიჩხეიძე = new Human("გიორგი ჩხეიძე");
        public static Human გიორგიგადელია = new Human("გიორგი გადელია");
        public static Human ზაქროსახიაშვილი = new Human("ზაქრო სახიაშვილი");
        public static Human მიქაძეკახაბერ = new Human("მიქაძე კახაბერ");
        public static Human იაკობიშვილიირაკლი = new Human("იაკობიშვილი ირაკლი");
        public static Human გიორგიმაღალდაძე = new Human("გიორგი მაღალდაძე");
        public static Human ამონაშვილიზვიადი = new Human("ამონაშვილი ზვიადი");
        public static Human ბეჟანჯინჭარაძე = new Human("ბეჟან ჯინჭარაძე");
        public static Human მერაბპაპასკუა = new Human("მერაბ პაპასკუა");
        public static Human ვასილკურტანიძე = new Human("ვასილ კურტანიძე");
        public static Human თორნიკეკაპანაძე = new Human("თორნიკე კაპანაძე");
        public static Human ათაბაგილიანა = new Human("ათაბაგი ლიანა");
        public static Human ჩაბრაძეშაქრო = new Human("ჩაბრაძე შაქრო");
        public static Human ჯემალალოიანი = new Human("ჯემალ ალოიანი");
        public static Human ალოიანიჯემალ = new Human("ალოიანი ჯემალ");
        public static Human ამირანფეტვიაშვილი = new Human("ამირან ფეტვიაშვილი");
        public static Human გვაჯაიათენგიზ = new Human("გვაჯაია თენგიზ");
        public static Human მაღრაძელევანი = new Human("მაღრაძე ლევანი");
        public static Human პაპიძეემზარ = new Human("პაპიძე ემზარ");
        public static Human ქუთათელაძეგიორგი = new Human("ქუთათელაძე გიორგი");
        public static Human ჯანელიძეალეკო = new Human("ჯანელიძე ალეკო");
        public static Human ისაევაალვინა = new Human("ისაევა ალვინა");
        public static Human ბალხამიშვილიმაია = new Human("ბალხამიშვილი მაია");
        public static Human ალბოროვაჟანა = new Human("ალბოროვა ჟანა");
        public static Human ზაქარიაყალაყაშვილი = new Human("ზაქარია ყალაყაშვილი");
        public static Human ბესიკითვარაძე = new Human("ბესიკი თვარაძე");
        public static Human ქალდანიგიორგი = new Human("ქალდანი გიორგი");
        public static Human გიორგიქალდანი = new Human("გიორგი ქალდანი");
        public static Human აკაკილობჟანიძე = new Human("აკაკი ლობჟანიძე");
        public static Human გოგაჯინიყაშვილი = new Human("გოგა ჯინიყაშვილი");
        public static Human ბარბაქაძებაკური = new Human("ბარბაქაძე ბაკური");
        public static Human მაღალდაძეზაზა = new Human("მაღალდაძე ზაზა");
        public static Human ნუკრიჯაგუნავა = new Human("ნუკრი ჯაგუნავა");
        public static Human ხორბალაძერობერტი = new Human("ხორბალაძე რობერტი");
        public static Human შოთაბურდული = new Human("შოთა ბურდული");
        public static Human რამისგულიევი = new Human("რამის გულიევი");
        public static Human ჯინორიძექრისტინე = new Human("ჯინორიძე ქრისტინე");
        public static Human ირაკლიზარანდია = new Human("ირაკლი ზარანდია");
        public static Human ზარანდიაირაკლი = new Human("ზარანდია ირაკლი");
        public static Human მაგამედოვიქამილა = new Human("მაგამედოვი ქამილა");
        public static Human ოსმანოვიბახადინ = new Human("ოსმანოვი ბახადინ");
        public static Human კვიწინაძემამუკა = new Human("კვიწინაძე მამუკა");
        public static Human ვიტალიფიფია = new Human("ვიტალი ფიფია");
        public static Human დავითირემაშვილი = new Human("დავით ირემაშვილი");
        public static Human ბესარიონსურმავა = new Human("ბესარიონ სურმავა");
        public static Human ნუგზარგოგოლაშვილი = new Human("ნუგზარ გოგოლაშვილი");
        public static Human ქარდავანათელა = new Human("ქარდავა ნათელა");
        public static Human შოთაშარბანაშვილი = new Human("შოთა შარბანაშვილი ");
        public static Human გიორგიჟღენტი = new Human("გიორგი ჟღენტი");
        public static Human ნინოსოხაშვილი = new Human("ნინო სოხაშვილი");
        public static Human თამაზფერსაშვილი = new Human("თამაზ ფერსაშვილი");
        public static Human მარიამწიკლაური = new Human("მარიამ წიკლაური");
        public static Human საკანდელიძებესარიონ = new Human("საკანდელიძე ბესარიონ");
        public static Human სოფიობლიაძე = new Human("სოფიო ბლიაძე");
        public static Human ბეჭვაიაირაკლი = new Human("ბეჭვაია ირაკლი");
        public static Human თორაძეგიორგი = new Human("თორაძე გიორგი");
        public static Human გოჩამოდებაძე = new Human("გოჩა მოდებაძე");
        public static Human ჯაჯანიძელაშა = new Human("ჯაჯანიძე ლაშა");
        public static Human ბედოიძეპავლე = new Human("ბედოიძე პავლე");
        public static Human ლიკახიდაშელი = new Human("ლიკა ხიდაშელი");
        public static Human სოფიოჟვანია = new Human("სოფიო ჟვანია");
        public static Human მეგიბეროძე = new Human("მეგი ბეროძე");
        public static Human ლომერახალაია = new Human("ლომერ ახალაია");
        public static Human მადონალორთქიფანიძე = new Human("მადონა ლორთქიფანიძე");
        public static Human რამაზსამყურაშვილი = new Human("რამაზ სამყურაშვილი");
        public static Human იზოლდაგოგბერაშვილი = new Human("იზოლდა გოგბერაშვილი");
        public static Human კობანოზაძე = new Human("კობა ნოზაძე");
        public static Human გოჩალაზარიშვილი = new Human("გოჩა ლაზარიშვილი");
        public static Human ჯამბურიძეიზოლდა = new Human("ჯამბურიძე იზოლდა");
        public static Human სოლომნიშვილილეილა = new Human("სოლომნიშვილი ლეილა");
        public static Human ზვიადმუსერიძე = new Human("ზვიად მუსერიძე");
        public static Human გაგუაელენე = new Human("გაგუა ელენე");
        public static Human გორჯელაძერამაზ = new Human("გორჯელაძე რამაზ");
        public static Human ჩაკვეტაძეშალვა = new Human("ჩაკვეტაძე შალვა");
        public static Human ბოლაშვილიზურაბ = new Human("ბოლაშვილი ზურაბ");
        public static Human ბიგვავადალი = new Human("ბიგვავა დალი");
        public static Human ილიაკოტაშვილი = new Human("ილია კოტაშვილი");
        public static Human ნუცუბიძენესტანი = new Human("ნუცუბიძე ნესტანი");
        public static Human გუსეინოვიაბას = new Human("გუსეინოვი აბას");
        public static Human მიხეილგურჯიძე = new Human("მიხეილ გურჯიძე");
        public static Human ტურაშვილინანა = new Human("ტურაშვილი ნანა");
        public static Human მებაღიშვილიელიზა = new Human("მებაღიშვილი ელიზა");
        public static Human აბბასოვისალეჰ = new Human("აბბასოვი სალეჰ");
        public static Human ივანიკაშვილიმიხეილ = new Human("ივანიკაშვილი მიხეილ");
        public static Human მსხვილიძედარინა = new Human("მსხვილიძე დარინა");
        public static Human ლოთუაშვილიოთარ = new Human("ლოთუაშვილი ოთარ");
        public static Human ხვიჩაბერიძე = new Human("ხვიჩა ბერიძე");
        public static Human ნიკოლოზიმეისრიშვილი = new Human("ნიკოლოზი მეისრიშვილი ");
        public static Human სოხაძედავით = new Human("სოხაძე დავით");
        public static Human ლოხიაურიდავით = new Human("ლოხიაური დავით");
        public static Human ალხანაიძეგოჩა = new Human("ალხანაიძე გოჩა");
        public static Human უსტარაშვილინათია = new Human("უსტარაშვილი ნათია");
        public static Human ნუფტულაევიადილ = new Human("ნუფტულაევი ადილ");
        public static Human დავითოქროპირიძე = new Human("დავით ოქროპირიძე");
        public static Human ნონამანიჟაშვილი = new Human("ნონა მანიჟაშვილი");
        public static Human ჩაჩიბაიადავით = new Human("ჩაჩიბაია დავით");
        public static Human ჭრელაშვილიარჩილ = new Human("ჭრელაშვილი არჩილ");
        public static Human მაძღარაშვილიგელა = new Human("მაძღარაშვილი გელა");
        public static Human კიტრიაშვილისულიკო = new Human("კიტრიაშვილი სულიკო");
        public static Human ჯანეზაშვილიაბესალომ = new Human("ჯანეზაშვილი აბესალომ");
        public static Human გაგლოევიზაზა = new Human("გაგლოევი ზაზა");
        public static Human ვალერიანგვიშიანი = new Human("ვალერიან გვიშიანი");
        public static Human მიხეილბოღოლაშვილი = new Human("მიხეილ ბოღოლაშვილი");
        public static Human ტყეშელაშვილიავთანდილ = new Human("ტყეშელაშვილი ავთანდილ");
        public static Human ბაინდურაშვილიალექსანდრე = new Human("ბაინდურაშვილი ალექსანდრე");
        public static Human გელამამულაშვილი = new Human("გელა მამულაშვილი");
        public static Human გოგოხიაკახაბერ = new Human("გოგოხია კახაბერ");
        public static Human კუხიანიძედავითი = new Human("კუხიანიძე დავითი");
        public static Human გოგაკუხალეიშვილი = new Human("გოგა კუხალეიშვილი");
        public static Human ილიაგოგეშვილი = new Human("ილია გოგეშვილი");
        public static Human ზურაბაბშილავა = new Human("ზურაბ აბშილავა");
        public static Human გვალიაპაატა = new Human("გვალია პაატა");
        public static Human იმნაძედავით = new Human("იმნაძე დავით");
        public static Human ბარამიძეკახა = new Human("ბარამიძე კახა");
        public static Human კალანდაძემადლენა = new Human("კალანდაძე მადლენა");
        public static Human კონწლიაშვილიიოსებ = new Human("კონწლიაშვილი იოსებ");
        public static Human ლევანშავგულიძე = new Human("ლევან შავგულიძე");
        public static Human მინდიაპაკელიანია = new Human("მინდია პაკელიანია");
        public static Human ნათიკკასანოვი = new Human("ნათიკ კასანოვი");
        public static Human გიორგიმილაძე = new Human("გიორგი მილაძე");
        public static Human ძიძიშვილიბესიკ = new Human("ძიძიშვილი ბესიკ");
        public static Human ბლიაძელია = new Human("ბლიაძე ლია");
        public static Human კონსტანტინემეგრელიშვილი = new Human("კონსტანტინე მეგრელიშვილი");
        public static Human მიხეილქურციკიძე = new Human("მიხეილ ქურციკიძე");
        public static Human მირზამირაზანაშვილი = new Human("მირზა მირაზანაშვილი");
        public static Human ლაშაალანია = new Human("ლაშა ალანია");
        public static Human ვაჟაქავთარაძე = new Human("ვაჟა ქავთარაძე");
        public static Human პაქსაძეემზარ = new Human("პაქსაძე ემზარ");
        public static Human იზაბელასახოკია = new Human("იზაბელა სახოკია");
        public static Human წიწიკაშვილიზაზა = new Human("წიწიკაშვილი ზაზა");
        public static Human რომანიხატისაშვილი = new Human("რომანი ხატისაშვილი");
        public static Human სორდიალიკა = new Human("სორდია ლიკა");
        public static Human გაბედავაიზა = new Human("გაბედავა იზა");
        public static Human გიორგისაამიშვილი = new Human("გიორგი საამიშვილი");
        public static Human ბეჟანიპაპიაშვილი = new Human("ბეჟანი პაპიაშვილი");
        public static Human ირმამჟავანაძე = new Human("ირმა მჟავანაძე");
        public static Human ეკაოსიშვილი = new Human("ეკა ოსიშვილი");
        public static Human გიზოაბდუშელიძე = new Human("გიზო აბდუშელიძე");
        public static Human მიხეილისამხარაძე = new Human("მიხეილი სამხარაძე");
        public static Human ჯუმბერირიჟვაძე = new Human("ჯუმბერი რიჟვაძე");
        public static Human ზაურბერიძე = new Human("ზაურ ბერიძე");
        public static Human როლანდიბოლქვაძე = new Human("როლანდი ბოლქვაძე");
        public static Human დადუნაშვილიგივი = new Human("დადუნაშვილი გივი");
        public static Human ქურთიაშვილიმანანა = new Human("ქურთიაშვილი მანანა");
        public static Human ალბინაალბოროვა = new Human("ალბინა ალბოროვა");
        public static Human ტარიელტაბატაძე = new Human("ტარიელ ტაბატაძე");
        public static Human ვალიშვილითემურ = new Human("ვალიშვილი თემურ");
        public static Human მიხეილკუტუბიძე = new Human("მიხეილ კუტუბიძე");
        public static Human შულაიაგიორგი = new Human("შულაია გიორგი");
        public static Human ილიაკორინთელი = new Human("ილია კორინთელი");
        public static Human ნანაროგავა = new Human("ნანა როგავა");
        public static Human დავითშაინიძე = new Human("დავით შაინიძე");
        public static Human ლევანახალაია = new Human("ლევან ახალაია");
        public static Human ლასხიშვილიგიორგი = new Human("ლასხიშვილი გიორგი");
        public static Human გიორგიგახოკიძე = new Human("გიორგი გახოკიძე ");
        public static Human გახოკიძეგიორგი = new Human("გახოკიძე გიორგი");
        public static Human სვანაძეთამრიკო = new Human("სვანაძე თამრიკო");
        public static Human მალაციძენინო = new Human("მალაციძე ნინო");
        public static Human ჩხიკვაძეგოჩა = new Human("ჩხიკვაძე გოჩა");
        public static Human ვართანიანიგაიანე = new Human("ვართანიანი გაიანე");
        public static Human თეიმურაზლუხუტაშვილი = new Human("თეიმურაზ ლუხუტაშვილი");
        public static Human ბალავაძემარინა = new Human("ბალავაძე მარინა");
        public static Human მიკუჩაძეაკაკი = new Human("მიკუჩაძე აკაკი");
        public static Human გურამგოცაძე = new Human("გურამ გოცაძე");
        public static Human ფარეშიშვილიშოთა = new Human("ფარეშიშვილი შოთა");
        public static Human giorgaZedaviT = new Human("giorgaZe daviT");
        public static Human გოდერძითვაური = new Human("გოდერძი თვაური");
        public static Human ილიადვალი = new Human("ილია დვალი");
        public static Human თამართელია = new Human("თამარ თელია");
        public static Human თეიმურაზჯანიაშვილი = new Human("თეიმურაზ ჯანიაშვილი");
        public static Human ედილაშვილიგულნარა = new Human("ედილაშვილი გულნარა");
        public static Human გიორგიმელქონიანი = new Human("გიორგი მელქონიანი");
        public static Human გაგნიძეგიორგი = new Human("გაგნიძე გიორგი");
        public static Human რომანგოგოლაძე = new Human("რომან გოგოლაძე");
        public static Human ცანკაშვილილია = new Human("ცანკაშვილი ლია");
        public static Human ნიკურაძეგიორგი = new Human("ნიკურაძე გიორგი");
        public static Human გიორგინიკურაძე = new Human("გიორგი ნიკურაძე");
        public static Human თეონაწერეთელი = new Human("თეონა წერეთელი");
        public static Human RAZMAZEGIORGI = new Human("RAZMAZE GIORGI");
        public static Human დათოჩახუნაშვილი = new Human("დათო ჩახუნაშვილი");
        public static Human ჯაბნიძეოთარ = new Human("ჯაბნიძე ოთარ");
        public static Human ბაბალეგაგოშვილი = new Human("ბაბალე გაგოშვილი");
        public static Human გიორგიჯელაძე = new Human("გიორგი ჯელაძე");
        public static Human ყეინაშვილინოდარ = new Human("ყეინაშვილი ნოდარ");
        public static Human ოთარიობაშვილი = new Human("ოთარ იობაშვილი");
        public static Human თოდაძეთორნიკე = new Human("თოდაძე თორნიკე");
        public static Human აბრამიშვილიდავით = new Human("აბრამიშვილი დავით");
        public static Human გივიზვერიაშვილი = new Human("გივი ზვერიაშვილი");
        public static Human ზურაბივანიაშვილი = new Human("ზურაბ ივანიაშვილი");
        public static Human ზურაბნონიაძე = new Human("ზურაბ ნონიაძე");
        public static Human გურბანგარაჯაევი = new Human("გურბან გარაჯაევი");
        public static Human გიაბიწაძე = new Human("გია ბიწაძე");
        public static Human მაისურაძენიკოლოზ = new Human("მაისურაძე ნიკოლოზ");
        public static Human გოჩასიხარულიძე = new Human("გოჩა სიხარულიძე");
        public static Human მზიადარჩიძე = new Human("მზია დარჩიძე");
        public static Human გოგიტიძეილია = new Human("გოგიტიძე ილია");
        public static Human გაბისონიამარინა = new Human("გაბისონია მარინა");
        public static Human ამირანბერუაშვილი = new Human("ამირან ბერუაშვილი");
        public static Human გაგაკოხტაშვილი = new Human("გაგა კოხტაშვილი");
        public static Human მერაბზარიძე = new Human("მერაბ ზარიძე");
        public static Human ნათიასიდამონიძე = new Human("ნათია სიდამონიძე");
        public static Human დოლიძეინგა = new Human("დოლიძე ინგა");
        public static Human რამაზგულიაშვილი = new Human("რამაზ გულიაშვილი");
        public static Human ირაკლიპაიჭაძე = new Human("ირაკლი  პაიჭაძე ");
        public static Human სეხნიაშვილითემურ = new Human("სეხნიაშვილი თემურ");
        public static Human ლედიცინაური = new Human("ლედი ცინაური");
        public static Human გივიალადაშვილი = new Human("გივი ალადაშვილი");
        public static Human ზაზასიჭინავა = new Human("ზაზა სიჭინავა                             ");
        public static Human კობამამინაიშვილი = new Human("კობა მამინაიშვილი");
        public static Human ნიკოლოზჩაფიჩაძე = new Human("ნიკოლოზ ჩაფიჩაძე");
        public static Human მალხაზმჭედლიშვილი = new Human("მალხაზ მჭედლიშვილი");
        public static Human გიორგიჩოხელი = new Human("გიორგი ჩოხელი");
        public static Human იოსებსარალიძე = new Human("იოსებ სარალიძე");
        public static Human რევაზაბრამიშვილი = new Human("რევაზ აბრამიშვილი");
        public static Human კახაბერფაჟავა = new Human("კახაბერ ფაჟავა");
        public static Human ზურაბქურდობაძე = new Human("ზურაბ ქურდობაძე");
        public static Human ყაჩმაზოვითენგიზი = new Human("ყაჩმაზოვი თენგიზი");
        public static Human vefxiSvililaSa = new Human("vefxiSvili laSa");
        public static Human ლევანმეგრელაძე = new Human("ლევან მეგრელაძე");
        public static Human ქეთევანცნობილაძე = new Human("ქეთევან ცნობილაძე");
        public static Human მარინაგელაშვილი = new Human("მარინა გელაშვილი");
        public static Human სხირტლაძეივანე = new Human("სხირტლაძე ივანე");
        public static Human ლაცაბიძეზვიადი = new Human("ლაცაბიძე ზვიადი");
        public static Human კოპაძესოფიკო = new Human("კოპაძე სოფიკო");
        public static Human როსტიაშვილილიანა = new Human("როსტიაშვილი ლიანა");
        public static Human მაკაქათამაძე = new Human("მაკა ქათამაძე ");
        public static Human პავლიაშვილილევან = new Human("პავლიაშვილი ლევან");
        public static Human ხიზანიშვილილაშა = new Human("ხიზანიშვილი ლაშა");
        public static Human მადონანაცვლიშვილი = new Human("მადონა ნაცვლიშვილი");
        public static Human შოშიტაშვილიგიორგი = new Human("შოშიტაშვილი გიორგი");
        public static Human გასანოვინოვრუზ = new Human("გასანოვი ნოვრუზ");
        public static Human სხილაძეზურაბ = new Human("სხილაძე ზურაბ");
        public static Human ივეჩიანიგოგა = new Human("ივეჩიანი გოგა");
        public static Human შაინიძედავით = new Human("შაინიძე დავით");
        public static Human რომანკეკელიძე = new Human("რომან კეკელიძე");
        public static Human ოთარგულიკაშვილი = new Human("ოთარ გულიკაშვილი");
        public static Human გიგაშვილიქრისტინე = new Human("გიგაშვილი ქრისტინე");
        public static Human სალომედავითულიანი = new Human("სალომე დავითულიანი");
        public static Human დავითბულიავა = new Human("დავით ბულიავა");
        public static Human დოდონაჭყებია = new Human("დოდო ნაჭყებია             ");
        public static Human ნანიშელია = new Human("ნანი შელია                                ");
        public static Human ეკატერინექლიბაძე = new Human("ეკატერინე ქლიბაძე              ");
        public static Human აიდინჯავადოვი = new Human("აიდინ ჯავადოვი           ");
        public static Human ზაქარიაძეჯანსულ = new Human("ზაქარიაძე ჯანსულ");
        public static Human თამაზბერიძე = new Human("თამაზ ბერიძე");
        public static Human ბარნაბიშვილითეონა = new Human("ბარნაბიშვილი თეონა");
        public static Human გოჩაკაპანაძე = new Human("გოჩა კაპანაძე                                  ");
        public static Human მაჩიტიძეკობა = new Human("მაჩიტიძე კობა");
        public static Human კრიხელითამარი = new Human("კრიხელი თამარი");
        public static Human გელაჯაბნიძე = new Human("გელა ჯაბნიძე                            ");
        public static Human შალვასუქასოვი = new Human("შალვა სუქასოვი");
        public static Human მარინეგაზაშვილი = new Human("მარინე გაზაშვილი");
        public static Human გიორგიღვალაძე = new Human("გიორგი ღვალაძე");
        public static Human ძიძიგურიზაზა = new Human("ძიძიგური ზაზა");
        public static Human ქოქაშვილიზვიად = new Human("ქოქაშვილი ზვიად");
        public static Human ქაფიანიძედავით = new Human("ქაფიანიძე დავით");
        public static Human რატიავალერიანი = new Human("რატია ვალერიანი");
        public static Human თიგიშვილირობერტი = new Human("თიგიშვილი რობერტი");
        public static Human ბუბუტეიშვილიმამია = new Human("ბუბუტეიშვილი მამია");
        public static Human ციციშვილითაიზი = new Human("ციციშვილი თაიზი");
        public static Human barbaqaZeTamar = new Human("barbaqaZe Tamar");
        public static Human ზაზანოზაძე = new Human("ზაზა ნოზაძე");
        public static Human ხოსიტაშვილიზურაბი = new Human("ხოსიტაშვილი ზურაბი");
        public static Human ხმალაძეანა = new Human("ხმალაძე ანა");
        public static Human ელზახაჭაპურიძე = new Human("ელზა ხაჭაპურიძე                      ");
        public static Human შოთახელაძე = new Human("შოთა ხელაძე");
        public static Human დედალამაზიშვილიდალი = new Human("დედალამაზიშვილი დალი");
        public static Human გიორგიცომაია = new Human("გიორგი ცომაია");
        public static Human პავლიაშვილინუკრი = new Human("პავლიაშვილი ნუკრი");
        public static Human ნატალიაქადაგიძე = new Human("ნატალია ქადაგიძე");
        public static Human ხუციშვილიზაზა = new Human("ხუციშვილი ზაზა");
        public static Human რამაზლაშხია = new Human("რამაზ ლაშხია");
        public static Human ზურაბჩიხელიძე = new Human("ზურაბ ჩიხელიძე");
        public static Human წიქარიშვილინანა = new Human("წიქარიშვილი ნანა");
        public static Human ბეგლარიშვილისოფიკო = new Human("ბეგლარიშვილი სოფიკო");
        public static Human საჩეჩელაშვილიმანანა = new Human("საჩეჩელაშვილი მანანა");
        public static Human გიორგიკაკაშვილი = new Human("გიორგი კაკაშვილი                          ");
        public static Human კუსრაშვილიმიხეილი = new Human("კუსრაშვილი მიხეილი");
        public static Human მიხეილშამოევი = new Human("მიხეილ შამოევი                     ");
        public static Human ვიბლიანიმაკა = new Human("ვიბლიანი მაკა");
        public static Human გაბოძენინელი = new Human("გაბოძე ნინელი");
        public static Human თორნიკეჯოხაძე = new Human("თორნიკე ჯოხაძე                             ");
        public static Human ბენიამინხუსკივაძე = new Human("ბენიამინ ხუსკივაძე              ");
        public static Human იაგუბოვიიფრატ = new Human("იაგუბოვი იფრატ");
        public static Human ჯავახიშვილიდავითი = new Human("ჯავახიშვილი დავითი");
        public static Human ხაჩიძეეკატერინე = new Human("ხაჩიძე ეკატერინე");
        public static Human რუსუდანელიავა = new Human("რუსუდან ელიავა");
        public static Human ქაჯაიაირაკლი = new Human("ქაჯაია ირაკლი");
        public static Human ბაქრაძეგიორგი = new Human("ბაქრაძე გიორგი");
        public static Human ჩალაბაშვილიგიგა = new Human("ჩალაბაშვილი გიგა");
        public static Human მამარიანიმურაზ = new Human("მამარიანი მურაზ");
        public static Human ეთერკორკოტაშვილი = new Human("ეთერ კორკოტაშვილი");
        public static Human ჯანაშვილიზვიადი = new Human("ჯანაშვილი ზვიადი");
        public static Human ჩილაჩავაკობა = new Human("ჩილაჩავა კობა");
        public static Human ოგნაძეინგა = new Human("ოგნაძე ინგა");
        public static Human ფანცხავასოფიო = new Human("ფანცხავა სოფიო");
        public static Human კალანდაძეთემურ = new Human("კალანდაძე თემურ");
        public static Human გრიგალაშვილიცისანა = new Human("გრიგალაშვილი ცისანა");
        public static Human ვიქტორიაპოლოზენკო = new Human("ვიქტორია პოლოზენკო");
        public static Human მათიაშვილინოდარ = new Human("მათიაშვილი ნოდარ");
        public static Human სოფიოდონდუა = new Human("სოფიო დონდუა");
        public static Human ჭოლაძემანანა = new Human("ჭოლაძე მანანა");
        public static Human ინეზაჯაბუა = new Human("ინეზა ჯაბუა                             ");
        public static Human ანაყავლაშვილი = new Human("ანა ყავლაშვილი");
        public static Human არაბულიმამუკა = new Human("არაბული მამუკა");
        public static Human ფურცხვანიძესოფიო = new Human("ფურცხვანიძე სოფიო");
        public static Human ბექაცერცვაძე = new Human("ბექა ცერცვაძე");
        public static Human გიორგიბეროშვილი = new Human("გიორგი ბეროშვილი");
        public static Human გურჩიანივიქტორია = new Human("გურჩიანი ვიქტორია");
        public static Human იმერლიშვილიმარინე = new Human("იმერლიშვილი მარინე");
        public static Human ხიზანიშვილიგვანცა = new Human("ხიზანიშვილი გვანცა");
        public static Human კალატოზიშვილიქეთევანი = new Human("კალატოზიშვილი ქეთევანი");
        public static Human ლავრენტლასარეიშვილი = new Human("ლავრენტ ლასარეიშვილი        ");
        public static Human დავითსახვაძე = new Human("დავით სახვაძე                                         ");
        public static Human გამრეკელითამარ = new Human("გამრეკელი თამარ");
        public static Human ტეფნაძეთეონა = new Human("ტეფნაძე თეონა");
        public static Human ჭანტურიძეთეიმურაზ = new Human("ჭანტურიძე თეიმურაზ");
        public static Human ჩინჩახაშვილითამარი = new Human("ჩინჩახაშვილი თამარი");
        public static Human გელაშვილიკობა = new Human("გელაშვილი კობა");
        public static Human იუზათედეევა = new Human("იუზა თედეევა");
        public static Human იმედამიქელაძე = new Human("იმედა მიქელაძე");
        public static Human boWoriSvilimamuka = new Human("boWoriSvili mamuka");
        public static Human უნგიაძეირინა = new Human("უნგიაძე ირინა");
        public static Human სულხანიშვილიგიორგი = new Human("სულხანიშვილი გიორგი");
        public static Human ანზორიხუციძე = new Human("ანზორი ხუციძე");
        public static Human ინაელიბეკოვა = new Human("ინა ელიბეკოვა");
        public static Human ვანობებუთაშვილი = new Human("ვანო ბებუთაშვილი");
        public static Human აკაკირუაძე = new Human("აკაკი რუაძე");
        public static Human ლევანგაგნიძე = new Human("ლევან გაგნიძე");
        public static Human დავითცერცვაძე = new Human("დავით ცერცვაძე");
        public static Human ნიკოლოზინასარიძე = new Human("ნიკოლოზ ინასარიძე");
        public static Human ჯუმბერშუბითიძე = new Human("ჯუმბერ შუბითიძე");
        public static Human დავითმაჭარაშვილი = new Human("დავით მაჭარაშვილი");
        public static Human დავითჭინჭარაული = new Human("დავით ჭინჭარაული");
        public static Human ძაძამიათენგიზ = new Human("ძაძამია თენგიზ");
        public static Human ნიკოლეიშვილითეოფანე = new Human("ნიკოლეიშვილი თეოფანე");
        public static Human რობიკოვაზაგაშვილი = new Human("რობიკო ვაზაგაშვილი");
        public static Human ქავთარაძემირიან = new Human("ქავთარაძე მირიან");
        public static Human კირაკოსიანირაფაელი = new Human("კირაკოსიანი რაფაელი");
        public static Human გაბაძეკარინა = new Human("გაბაძე კარინა");
        public static Human მამედოვიიოლჩი = new Human("მამედოვი იოლჩი");
        public static Human გილაურიდავით = new Human("გილაური დავით");
        public static Human შიშნიაშვილიდიმიტრი = new Human("შიშნიაშვილი დიმიტრი");
        public static Human ალექსანიანიმიხეილ = new Human("ალექსანიანი მიხეილ");
    }
}