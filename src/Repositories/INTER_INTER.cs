// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   DataSource.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Entities=WPAppStudio.Entities;
using RepositoriesBase=WPAppStudio.Repositories.Base;
using WPAppStudio.Shared;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// INTER_INTER data source.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public class INTER_INTER : IINTER_INTER 
    {
		private const int MaxResults = 10;
        private readonly ObservableCollection<Entities.INTERSchema> _data = new ObservableCollection<Entities.INTERSchema>
		{
          new Entities.INTERSchema
            {
                Id= new Guid("fa1559d4-c556-4f73-8cf3-e4fc62533cc1"),
                Title=@" I Am Legend",
                Subtitle=@"https://www.youtube.com/watch?v=ewpYq9rgg3w",
                Image=@"\Images\Item-0dd66704-f70e-4477-b41f-fb3d76501544.jpg",
                Description=@"ผมชื่อโรเบิร์ต เนวิลล์ ผมเป็นผู้รอดชีวิตอยู่ในนิวยอร์ค ซิตี้ ถ้ามีใครอยู่ข้างนอกนั่น...ใครก็ตาม ได้โปรด คุณไม่ได้อยู่คนเดียว 

   โรเบิร์ต เนวิลล์ (วิล สมิธ) เป็นนักวิทยาศาสตร์ปราดเปรื่อง แต่แม้กระทั่งเขาก็ไม่อาจจำกัดวงไวรัสร้ายที่ไม่มีทางยับยั้ง ไม่มีทางรักษา และถูกสร้างขึ้นด้วยมือมนุษย์ เนวิลกลายเป็นมนุษย์คนสุดท้ายที่รอดชีวิตอยู่ในนิวยอร์ค ซิตี้ และอาจจะในโลกนี้ เป็นเวลา 3 ปีที่เนวิลล์เพียรส่งสารผ่านคลื่นวิทยุทุกวัน เขาหมดหวังที่จะพบกับผู้รอดชีวิตคนอื่นๆ ในโลกภายนอก 

   แต่เขาไม่ได้อยู่ลำพัง บรรดาเหยื่อโรคระบาดกลายพันธุ์ ""พวกติดเชื้อ"" ซึ่งซ่อนอยู่ในเงามืด เฝ้าจับตาทุกย่างก้าวของเนวิลล์ และคอยให้เขาพลาด กับความหวังครั้งสุดท้ายของมนุษยชาติเนวิลล์มีแรงขับในภารกิจเดียวที่เหลืออยู่ของเขา คือหาทางที่จะกลับข้างผลจากไวรัสด้วยการใช้เลือดที่มีภูมิคุ้มกันของเขา แต่เขารู้ดีว่ามีกำลังเพียงน้อยนิด...และเวลาก็เหลือน้อยเต็มที  
",
			},
          new Entities.INTERSchema
            {
                Id= new Guid("8fb30b8a-2218-432f-9d19-b71e81baae65"),
                Title=@"Elysium",
                Subtitle=@"https://www.youtube.com/watch?v=qPogOtZLD3w",
                Image=@"\Images\Item-4638283e-04a9-483b-b6e1-5e4884e5b21a.jpg",
                Description=@"Elysium นั้นเป็นเรื่องเกี่ยวกับยุคอนาคตปี 2159 เมื่อคนเราแบ่งออกเป็น 2 ชนชั้น อันได้แก่พวกมหาเศรษฐีรวยล้นฟ้า และพวกที่มีฐานะด้อยกว่า ซึ่งพวกชนชั้นสูงจะได้อยู่บนดาว Elysium ในขณะที่ชนชั้นล่างจะต้องอยู่บนดาวโลกที่เสื่อมโทรมลงมากแล้ว.. 

    ทำให้คนชนชั้นล่างพากันเรียกร้องขอความเป็นธรรมเพื่อจะได้ไปอยู่บนดาวที่เจริญแล้วบ้าง แต่ก็ถูกโรดส์ เจ้าหน้าที่รัฐบาลขัดขวาง ในขณะเดียวกัน ชายชื่อแมกซ์ผู้ทนอยู่ในสถานการณ์สิ้นไร้ความหวังแบบนี้ไม่ไหวอีกต่อไป ก็ได้ตัดสินใจลุกขึ้นเดินหน้าเรียกร้องความยุติธรรม เพื่อชีวิตที่ดีขึ้นของตัวเองและผู้คนอีกมากมาย!!  ",
			},
          new Entities.INTERSchema
            {
                Id= new Guid("d6b35e1f-b3e0-4379-9cb4-92c848839b13"),
                Title=@"The Frozen Ground",
                Subtitle=@"https://www.youtube.com/watch?v=KOxFPv-meWM",
                Image=@"\Images\Item-2bfd72a9-45b6-42ce-8f05-336c0b3da4dc.jpg",
                Description=@"จ่าแจ็ค ฮัลคอมบ์ (นิโคลัส เคจ) เชื่อมั่นว่า โรเบิร์ต แฮนเซ่น (จอห์น คูแซค) คือฆาตกรฆ่าต่อเนื่องที่ชอบลักพาตัวหญิงสาวมากักขังเพื่อทรมานและกระทำการทารุณกรรมทางเพศก่อนที่จะฆ่าเหยื่อทิ้งทุกราย แต่แจ็ค ยังไม่มีหลักฐานเพียงพอที่จะขอหมายค้นและจับกุม แจ็ครู้มาว่าซินดี้ (วาเนสซา ฮัดเจนส์) โสเภณีวัย 17 คือเหยื่อรายหนึ่งของโรเบิร์ตที่รอดชีวิตมาได้ เขาจึงตามหาซินดี้และขอร้องให้มาช่วยเขา ทว่าซินดี้คือสาวใจแตกที่ไม่เคยไว้ใจใคร แจ็คจึงต้องพยายามซื้อใจซินดี้ให้ได้ แต่จะเป็นอย่างไรถ้าฆาตกรอย่างโรเบิร์ตก็กำลังตามรอยซินดี้เช่นกัน!! ",
			},
          new Entities.INTERSchema
            {
                Id= new Guid("e1f33a5b-d8f6-48b1-b230-858be24b6ec6"),
                Title=@"The Hunger Games ",
                Subtitle=@"https://www.youtube.com/watch?v=5DX6EfQnRBU",
                Image=@"\Images\Item-905a1a45-b9c7-42c1-ba23-d1a447a036fc.jpg",
                Description=@"ในอนาคตสงครามทำให้โลกกลายเป็นยุคมืดอีกครั้ง ทั้ง 12 เขตตกอยู่ภายใต้การปกครองของ ""แคปปิตอล"" ที่กำหนดให้ทั้ง 12 เขตจะต้องส่งเด็กผู้หญิงหนึ่งและเด็กผู้ชายหนึ่ง เข้าร่วม Hunger Games ที่มีกฎง่าย ๆ คือให้เด็กทั้ง 24 คนต่อสู้กันต่อหน้าทีวีจนเหลือผู้รอดเพียงคนเดียวทุกปี 

   เมื่อน้องสาวของ แคตนิส เอเวอร์ดีน (เจนนิเฟอร์ ลอว์เรนซ์) จากเขต 12 กลายเป็นผู้โชคร้ายคนล่าสุด เธอไม่มีทางเลือกนอกจากเสนอตัวเองแทน และต้องเดินทางไปเข้าร่วมเกมกับ พีตา เมลลาร์ก (จอช ฮัทเชอร์สัน) ตัวแทนจากเขตอีกคน โดยมี เกล (เลียม เฮมส์เวิร์ธ) เพื่อนสนิทของ แคทนิส ที่พยายามช่วยเธอจากเกมมรณะนี้... แคทนิส ต้องเลือกระหว่างมนุษยธรรมหรือการเอาตัวรอด ชีวิตหรือความรัก จุดมุ่งหมายเดียวก็คือการเอาชนะเกมล่าชีวิตเพื่อกลับบ้าน  ",
			},
          new Entities.INTERSchema
            {
                Id= new Guid("be1df217-9383-49d2-b0a1-eee596cd07cf"),
                Title=@"The Wolverine เดอะวูล์ฟเวอรีน",
                Subtitle=@"https://www.youtube.com/watch?v=GHG5emr77Ds",
                Image=@"\Images\Item-6359d5c9-d906-4025-b814-86c59a7c4cbc.jpeg",
                Description=@"The Wolverine ที่สร้างขึ้นจากตัวละครที่มีชื่อเสียงโด่งดังจากหนังสือการ์ตูน มหากาพย์แอ็คชั่นผจญภัยซึ่งครั้งนี้ได้นำ วูล์ฟเวอรีน (ฮิวจ์ แจ็คแมน) ตัวละครในจักรวาลแห่งเอ็กซ์เมนที่มีภาพติดตาที่สุดไปอยู่ในประเทศญี่ปุ่น ยุคปัจจุบัน เขากลายเป็นผู้ไร้ความสามารถที่ต้องอยู่ในโลกลึกลับ และต้องพบกับความพ่ายแพ้ในสมรภูมิรบที่เสี่ยงต่อความเป็นความตาย ซึ่งจะทำให้เขาต้องกลายพันธุ์ไปตลอดกาล นี่เป็นครั้งแรกที่เขาจะอ่อนแอ และต้องผลักดันทั้งกายและใจตัวเองให้ถึงขีดสุด เขาไม่เพียงพบกับซามูไรเหล็กตัวฉกาจเท่านั้น แต่ยังต้องสู้กับความเป็นอมตะในตัวเอง ครั้งนี้เขาจะมีพลังมากกว่าที่เราเคยเห็นมาก่อน!! 
 ",
			},
		};
	
		
        /// <summary>
        /// Retrieves the data from a static data source, in an observable collection of INTERSchema items.
        /// </summary>
        /// <returns>An observable collection of INTERSchema items.</returns>
        public ObservableCollection<Entities.INTERSchema> GetData(int numPage)
        {								
			return new ObservableCollection<Entities.INTERSchema>(_data.Skip(MaxResults * numPage).Take(MaxResults));
        }
		
		/// <summary>
        /// Retrieves the data from a static data source, filtered by a filter specification, in an observable collection of INTERSchema items.
        /// </summary>
		/// <param name="filter">Filter operation specification</param>
        /// <returns>An observable collection of INTERSchema items.</returns>
        public ObservableCollection<Entities.INTERSchema> Search(FilterSpecification filter)
        {
            return RepositoriesBase.Filter<Entities.INTERSchema>.FilterCollection(filter, _data);
        }
		
		/// <summary>
        /// Checks if data source has a element before the passed as parameter
        /// </summary>
		/// <param name="current">Current element</param>
        /// <returns>True, if there is a previous element, false if there is not</returns>
		public bool HasPrevious(Entities.INTERSchema current)
        {
            if (current == null || !_data.Any()) return false;

            return _data.IndexOf(current) > 0;
        }
		
		/// <summary>
        /// Checks if data source has a element after the passed as parameter
        /// </summary>
		/// <param name="current">Current element</param>
        /// <returns>True, if there is a next element, false if there is not</returns>
		public bool HasNext(Entities.INTERSchema current)
        {
            if (current == null || !_data.Any()) return false;

            return _data.IndexOf(current) < _data.Count - 1;
        }
		
		/// <summary>
        /// Retrieves the previous element from source.
        /// </summary>
		/// <param name="current">Current element</param>
        /// <returns>The previous element from items, if it exists. Otherwise, returns null</returns>
        public Entities.INTERSchema Previous(Entities.INTERSchema current)
        {
            if (current == null || !_data.Any()) return null;

            if (_data.First().Equals(current)) return null;

            return _data[_data.IndexOf(current) - 1];
        }
		
		/// <summary>
        /// Retrieves the next element from source.
        /// </summary>
		/// <param name="current">Current element</param>
        /// <returns>The next element from items, if it exists. Otherwise, returns null</returns>
        public Entities.INTERSchema Next(Entities.INTERSchema current)
        {
            if (current == null || !_data.Any()) return null;

            if (_data.Last().Equals(current)) return null;

            return _data[_data.IndexOf(current) + 1];
        }
	}
}

