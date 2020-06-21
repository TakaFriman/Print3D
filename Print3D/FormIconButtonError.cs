﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Print3D
{
    public partial class FormIconButtonError : Form
    {
        public FormIconButtonError()
        {
            InitializeComponent();
        }

        private void buttonApp_Click(object sender, EventArgs e)
        {
            FormError t = new FormError("Внешние провисания", "Часто используемое описание: Пластик между двумя деталями.\n\nОписание: Во время перехода печатающей головки от одной детали к другой или крупного элемента большой детали к другому такому же элементу возникает длинный тонкий слой пластика, который портит внешнюю форму детали (деталей). Это происходит из-за того, что пластик, который остается на кончике сопла, под действием силы тяжести и силы трения цепляется за одну деталь и начинает растягиваться. Разные виды пластика в зависимости от параметра жидкотекучести и времени затвердевания проявляют данный дефект.\n\nКак бороться:\n\n ● Использовать функцию retract \nБлагодаря этой функции печатающая головка вернет пластик обратно и, таким образом, уберет его с кончика сопла. Данная настройка активируется непосредственно в слайсере (если он поддерживает эту настройку). В слайсере «Cura» функция retract рисуется тонкими синими линиями, что позволяет на уровне готового задания проверить наличие данной ошибки.\n \n ● Увеличить скорость печати\nЕсли увеличить скорость печати, то уменьшится время, за которое пластик может зацепиться за деталь. Однако не всегда возможно изменить скорость, к тому же это может способствовать возникновению других дефектов.\n\n ● Изменить температуру печати\nТемпература печати напрямую влияет на текучесть пластика. Понижение температуры даже на 10 градусов существенно уменьшает эффект от внешних провисаний.");
            t.ShowDialog();
        }

        private void buttonWaviness_Click(object sender, EventArgs e)
        {
            FormError t = new FormError("Волнистость", "Часто используемое описание: Изменение цвета у краев детали, дефекты по краям.\n\nОписание: Данный дефект проявляется в виде потемнений и легкой волнистости вокруг острых концов. Если начать печатать текст, то это будет выглядеть, как легкий эффект тени. Причина заключается в инерции, которая сообщается жидкому пластику во время печати. Печатающая голова обладает большей массой относительно пластика, и во время резкой смены направления он не способен так же резко повторить траекторию. Это и вызывает легкую волнистость по углам.\n\nКак бороться:\n\n● Уменьшить скорость печати \nВ таком случае уменьшается резкость на поворотах, благодаря чему дефект устраняется.\n\n● Уменьшить ускорение печатающей головки\nЭти настройки доступны не во всех слайсерах, однако, это позволит избавиться от дефекта без уменьшения скорости печати.\n\n● Изменить температуру печати\nТемпература влияет на текучесть пластика, так что понижение температуры печати способствует устранению дефекта.");
            t.ShowDialog();
        }

        private void buttonBoil_Click(object sender, EventArgs e)
        {
            FormError t = new FormError("«Вскип», «Подутость»", "Часто используемое описание: Проблема с внешним слоем (наличие дырок на внешнем слое).\n\nОписание: Выступы на верхнем слое детали  могут быть как открытого, так и закрытого типа. Это связано с провисанием пластика, который не успевает охлаждаться будучи напечатанным в воздухе без поддержек. Из-за того, что таких слоев может быть несколько и все они некачественные, и происходит данный дефект.\n\nКак бороться:\n\n● Обеспечить охлаждение\nПластик должен хорошо остывать на верхнем слое. По рекомендациям, на этом этапе охлаждение должно идти максимально.\n\n● Обеспечить достаточную толщину слоя и стенки\nКроме достаточного охлаждения, должно быть необходимое количество слоев. По рекомендациям, стенка должна состоять, как минимум, в 6 слоев толщины. Таким образом, при печати слоем 0.1 мм желательно, чтобы  стенка была не менее 0.6 мм. Слишком тонкие базовые слои тоже не подойдут, так как они просто не будут держать себя и другие слои.\n\n● Изменить заполняемость\nНекоторые слайсеры изменяют конфигурацию заполняемости на определенном проценте заполнения, то есть разница может быть уже даже между 24% и 25%. Кроме этого, при большей заполняемости расстояние, которое печатается в воздухе меньше, что тоже может убрать данный дефект.");
            t.ShowDialog();
        }

        private void buttonDistortion_Click(object sender, EventArgs e)
        {
            FormError t = new FormError("Коробление", "Часто используемое описание: Отклеивается от платформы, изгибается.\n\nОписание: Искажение геометрии. Из-за перехода пластика из одного состояния в другое ( жидкое - твердо-жидкое - твердое ) и изменения температур, пластик начинает уменьшаться в объеме. Этот процесс проходит неравномерно: сначала остывают края, а затем только центральная часть. Из-за этого возникают внутренние напряжения, которые отрывают края или ломают деталь.\n\nКак бороться:\n\n● Уменьшить заполняемость\nМеньше пластика, меньше чему сжиматься - меньше усилие отрыва.\n\n● Использовать горячий стол\nПри прогревании нижних слоев происходит равномерное распределение напряженной внутри детали.\n\n● Делать внешний контур\nВы можете печатать внешний слой вокруг детали. Это создает что-то вроде термобарьера вокруг детали, тем самым поддерживая температуру по объему, что приводит к равномерному распределению напряжений по детали. Альтернатива - закрытая камера печати, служит аналогичным образом.\n\n● Использовать конструктивные элементы\nВо-первых, проверить чтобы  деталь хорошо лежала на столе, если  плоская грань детали вовсе не плоская, то она легко оторвется. Во-вторых, если можно понимаете физику процесса можете либо где-то добавить материала, либо сделать дырку в детали и пр. Таким образом вы искусственно вызовете перераспределение напряжений в детали, однако, этот способ крайне сложен.\n\n● Увеличить силу трения\nНе обязательно бороться с напряжениями, можно просто обеспечить необходимую силу сцепления.Однако, этот вариант не самый надежный, так как эти напряжения останутся, и деталь потом может легко сломаться.");
            t.ShowDialog();
        }

        private void buttonUnderextrusion_Click(object sender, EventArgs e)
        {
            FormError t = new FormError("Недоэкструзия", "Часто используемое описание: Дырки в печати, проблемы со слоями, дефекты на поверхности.\n\nОписание : Недоэсктрузия возникает из-за большого количества факторов, связанных как с самим принтером, так и с пластиком. Наблюдать ее очень легко: поверхность детали выходит не ровной, а с вкраплениями. Также это может быть связанно с отсутствием пластика там, где он необходим. Для устранения данного дефекта может потребоваться комплексный подход.\n\nКак бороться:\n\n● Изменить скорость\nНе все детали принтер может печатать на максимальной скорости.Также это может стать проблемой для некоторых видов пластика.Поэтому стоить обратить внимание на сам принтер, так как, возможно, он не может печатать на данной скорости.Чтобы устранить дефект можно попробовать его смазать, либо сменить пластик.Но сперва нужно уменьшить скорость и снова попытаться начать печать.\n\n● Сменить температуру\nУ всех видов пластика есть рекомендованные температуры для печати.Если температура не соответствует параметрам жидкотекучести по работе с определенным пластиком, печать будет некорректной.\n\n● Проверить пластик\nПластик может отсыреть, быть грязным или некачественным.То может привести к недоэкструзии, либо к полной остановке печати.Кроме того, пластик может сломаться из - за падающего механизма и собственных прочностных свойств.Возможно, печатать данным пластиком будет невозможно.Причиной данного дефекта так же может быть диаметр пластика, который постоянно смещается.Таким образом, смена пластика позволить понять, в чем заключается проблема: в принтере или расходнике.\n\n● Проверить подающий механизм\nМягкий пластик может слишком сильно переминаться, из - за чего возникают проблемы с печатью.В таком случае, необходимо ослабить захват прутка, однако, следует связаться с тех.поддержкой для лучшего результата.\n\n● Проверить  пруток\nИногда в ходе печати пруток может завязаться узлом, или же что - то может помешать поступать ему в экструдер.Поэтому стоит обязательно посмотреть на состояние прутка.\n\n● Сменить или прочистить сопло\nВ ходе работы сопло будет загрязняться из - за пыли, либо нагара пластика.Поэтому всегда нужно иметь пару сменных сопел, чтобы исправить проблему.Кроме того, чтобы очистить принтер от остатков старого пластика, нужно проделать печать на высокой температуре, иначе возникнут трудности в работе с принтером.\n\n● Проверить настройки слайсера\nНекоторые слайсеры могут использовать отвод сопла и его очистку для избавления от внешних провисаний.Из - за этого, когда печатающая голова возвращается, пластик не сразу начинает подаваться.Это может привести к недоэсктрузии в некоторых частях модели.\n\n● Проверить тефлоновую трубку\nИсправленный вариант: из - за грязи, допущенной в зоне печати, тефлоновая трубка может засориться.Вследствие этого пруток будет испытывать трение, что приведет к недоэкструзии.\n\n● Проверить шестерни\nЕсли шестерни, захватывающие пруток, будут работать неправильно, то выходить из сопла он будет проблемно.Если простые способы решения проблемы не помогли, то проверять нужно работоспособность всего механизма.");
            t.ShowDialog();
        }

        private void buttonUnderfill_Click(object sender, EventArgs e)
        {
            FormError t = new FormError("Недостаточное заполнение", "Часто используемое описание: Неправильное заполнение детали. Печать поддержек там, где их не должно быть.\n\nОписание: Вид дефекта, связанный с электронной моделью. Существует множество причин его возникновения: у полигонов неправильно направлены нормали; модель не до конца слита (есть отверстия); модель состоит из нескольких элементов. Это все может способствовать возникновению дефекта, который связан с тем, что слайсер не может выполнить установленных задач.\n\nКак бороться:\n\n● Проверить модель в Netfabb/Meshmixer\nС помощью специализированных продуктов можно проверить состояние модели и выявить ошибки.Они устраняют многие проблемы, которые были допущены перед печатью.Однако, данные программы могут исказить вашу геометрию.\n\n● Исправить электронную модель / nЕсли есть возможность воспользоваться функционалом 3D программ для исправления стенки, нужно проделать следующие действия: сшить стенки, закрыть пустоты, обратить нормали, после чего проверить получившийся q - code.В нем можно увидеть, как будет происходить печать модели, а также понять, устранен ли дефект.");
            t.ShowDialog();
        }

        private void buttonNotLayered_Click(object sender, EventArgs e)
        {
            FormError t = new FormError("Неслойность", "Часто используемое описание: Предметы круглой формой получаются не круглыми, не соблюдается параллельность.\n\nОписание: Иногда геометрия слоев не выполняется. Проявляется это в окружностях (они получается не идеальными) и в параллельных прямых (например, параллельные прямые сначала немного расходятся, а потом, наоборот, наслаиваются). Данная проблема связана с ремнями, идущими к шаговым моторам. Возможно, ремни недостаточно плотно крепятся.\n\nКак бороться:\n\n● Подтянуть ремни около печатающей головки\nЛучше всего обратиться за помощью к поставщику 3д принтера.\n\n● Проверить, чтобы все крепежи были плотно затянуты\nДля этого надо воспользоваться инструментом, который скорее всего шел у вас в комплекте\n\n● Смазать направляющие принтера \nДобавить буквально по одной капле легкой смазки на направляющие.");
            t.ShowDialog();
        }

        private void buttonNonСompliance_Click(object sender, EventArgs e)
        {
            FormError t = new FormError("Несоблюдение осей", "Часто используемое описание: Не соблюдается прямой угол.\n\nОписание: Данная проблема связана с тем, что ответные части механизма не встают в пазы из-за перекоса. Возможно, также, что голова принтера перемещается с усилием.\n\nКак бороться:\n\n● Редактирование осей\nДефект можно устранить только механически. Для этого нужно запросить у поставщика или производителя принтера информацию о том, как правильно скорректировать оси. После проделанной работы по исправлению дефекта, согласно инструкциям поставщика или производителя, нужно произвести донастройку принтера.");
            t.ShowDialog();
        }

        private void buttonSag_Click(object sender, EventArgs e)
        {
            FormError t = new FormError("Перекос", "Часто используемое описание: «Слои поплыли», вертикаль не соблюдается, слои не ложатся ровно друг на друга.\n\nОписание: Возможно несколько вариантов данного дефекта. Либо слои  неровно ложатся, либо модель печатается кусками, либо  легкий перекос. Данный дефект, как правило, связан с механической частью принтера. Из-за трения  фактический путь печатающей головки не сходится с тем, что был заложен в машину.\n\nКак бороться:\n\n● Проверить ремни\nВажно, чтобы они нормально лежали в местах контакта и нигде не перетирались. Следует посмотреть инструкцию принтера, чтобы исправить данный дефект.\n\n● Принтер смещает слои друг относительно друга \nВозможно, что не обеспечена фиксация шкивов должным образом. С помощью черного маркера можно отметить их положение, а после печати сравнить и подкрутить это место в случае необходимости.\n\n● Подвигать печатающую головку без питания\nОна должна двигаться без существенных проблем. Если это не так, то нужно смазать валы.\n\n● Проверить крепление\nИз-за плохого крепления есть вероятность того, что перпендикулярность осей X и Y не будет обеспечиваться. Это может привести к данному дефекту, а значит проблема «внутри» принтера.\n\n● Проверить печатную платформу \nСтекло на принтере может начать смещаться, причем в одном направлении. В таком случае нужно найти способ обеспечить его фиксацию.\n\n● Проблема с электроникой\nДанная причина дефекта маловероятна, но возможна.");
            t.ShowDialog();
        }

        private void buttonSkippedLayer_Click(object sender, EventArgs e)
        {

            FormError t = new FormError("Пропущенный слой", "Часто используемое описание: Слой отличается от остальных слоев модели. Модель слоится.\n\nОписание: Случай, когда один или несколько слоев отличаются от других. Затем идет стабильная печать и дефект может повторится. Может возникать из-за недоэкструзии или проблем механизма.\n\nКак бороться:\n\n● Устранить недоэкструзию \nТак как дефект может быть связан с недоэкструзией, нужно убедиться в том, что причина проблемы в ней. Если это действительно так, стоит ознакомиться с инструкцией по ее устранению.\n\n● Смазать Z-направляющую \nПоскольку стол перемещается по Z направлению, то, возможно, на каких-то участках скопилась грязь или не хватает смазки. По рекомендации производителя, следует смазать направляющую и проверить исправность принтера.\n\n● Проблема с подшибниками\nПроблема может быть связана не только с направляющими, но и другими элементами подъемного механизма.В таком случае стоит отрегулировать подшипники или отдать принтер в сервис.\n\n● Излишняя смазка \nСлишком много смазывающего материала использовать не стоит, так как он может начать скапливать грязь, что вновь приведет к появлению дефекта.Чтобы избавиться от него окончательно, нужно протереть валы и использовать необходимое количество смазки.\n\n● Проблема с электроникой\nНе всегда проблема связана с механической частью принтера.Иногда возникают неисправности в его электронной части.В таком случае будет лучше отдать принтер на ремонт.\n\n● Дефектные детали\nВозможно, в целом работа механизма исправна, но возникновению дефекта могут послужить отдельные детали.В таком случае принтер нужно разобрать и попытаться найти дефектную деталь, чтобы устранить проблему.");
            t.ShowDialog();
        }

        private void buttonPunchings_Click(object sender, EventArgs e)
        {
            FormError t = new FormError("Просечки", "Часто используемое описание: Стенки не соединяются между собой. Пустоты в стенках.\n\nОписание: Механическая проблема. Из-за ограниченного пути печатающей части возникают пустоты и нестыковка между стенками . Контакт может быть частичным, либо отсутствовать полностью.\n\nКак бороться:\n\n● Подтянуть ремни около печатающей головки\nСтоит обратиться к поставщику 3д принтера.\n\n● Уменьшить скорость печати\nВозможно, пластик плохо укладывается на скорости, которую принтер использует в данный момент, поэтому стоит изменить ее.Также этот дефект может исправить легкое увеличение температуры.\n\n● Изменить настройки стенки\nДанный дефект может возникнуть из - за принципа укладывания самой стенки, поэтому стоит изменить ее толщину.");
            t.ShowDialog();
        }

        private void buttonDowniness_Click(object sender, EventArgs e)
        {
            FormError t = new FormError("«Пушистость»", "Часто используемое описание: Модель как будто покрыта «волосами».«Сопли». Провисания.\n\nОписание: Уменьшенный вариант внешнего провисания. На модели торчат маленькие «волосы», которые остаются от печатающего сопла. Данный дефект может проявляться и в том случае, если сопло не осуществляет переход от одного объекта к другому.\n\nКак бороться:\n\n● Проверить пластик\nВозможно, пластик плохого качества, либо загрязнен. Нужно попробовать другой.\n\n● Проверить сопло \n«Пушистость» может быть признаком неисправности сопла. Нужно проверить его внешнюю часть на наличие в ней торчащих «волос», либо поменять старое сопло на новое.\n\n● Удалить дефект после работы с принтером\nЭто редкий вид дефекта, от которого довольно легко избавиться пост обработкой.Можно воспользоваться шкуркой, надфиль или другим удобным инструментом.");
            t.ShowDialog();
        }

        private void buttonLooseness_Click(object sender, EventArgs e)
        {
            FormError t = new FormError("Рыхлота", "Часто используемое описание: Провисание пластика на детали.\n\nОписание: Один из самых распространенных и базовых дефектов.Из - за печати «в воздухе» пластик провисает.Связано это с тем, что он не успевает остыть, и печатается без поддержки.Провисания могут возникать по разным причинам, хоть основа возникновения данного дефекта одинакова.Поэтому способ устранения этой проблемы не всегда очевиден.\n\nКак бороться:\n\n● Охлаждение\nПонадобится охлаждение или нет, зависит от самого пластика.Нужно обеспечить охлаждение настолько, насколько возможно, если это действительно необходимо.\n\n● Печатать больше одно детали\nВ случае мелких деталей процесс печати существенно улучшится, если печатать больше одной детали.Таким образом, источник тепла будет устранен, и у детали будет больше времени на то, чтобы остыть.\n\n ● Работа с толщиной слоя\nУменьшать или увеличивать слой нужно в зависимости от ситуации, так как, что делать точно, сказать без анализа невозможно.Но такой способ устранения дефекта может как и ухудшить состояние печати, так и улучшить.\n\n● Уменьшить скорость печати\nЧасто понижение скорости печати может улучшить качество  детали.\n\n● Понижение температуры\nЕсли понизить температуру, пластик будет быстрее охлаждаться.Однако слишком низкую температуру устанавливать также не стоит, иначе качество печати ухудшится.\n\n● Изменение позиции детали \nСтоит попытаться по - другому расположить деталь, но только в том случае, если это не повлияет на качество печати.Желательно подумать о том, как лучше расположить деталь, либо воспользоваться автопозиционированием(например, Meshmixer).");
            t.ShowDialog();
        }

        private void buttonStratification_Click(object sender, EventArgs e)
        {
            FormError t = new FormError("Слоистость нижнего слоя", "Часто используемое описание: Четко выраженный нижний слой, толстые линии нижнего слоя.\n\nОписание: Печать нижнего слоя – один из самых основных моментов в печати. При слишком близкой печати, может произойти дефект «слоновьей ноги». Но если возникает большой зазор, то получается излишняя слоистость нижнего слоя.\n\nКак бороться:\n\n● Уменьшить толщину первого слоя \nВо многих слайсерах есть возможность изменения первых слоев печати. Стоит попробовать сделать ее меньше для достижения желаемого результата.\n\n● Повторная калибровка\nКалибровка стола может решить множество проблем, возникших из-за слоистости нижних слоев. Уменьшив расстояние, можно устранить данный дефект.");
            t.ShowDialog();
        }

        private void buttonElephantLeg_Click(object sender, EventArgs e)
        {
            FormError t = new FormError("«Слоновья нога»", "Часто используемое описание:  Толстые нижние слои, несхожие слои в основании.\n\nОписание: Нижние слои детали по площади больше, чем должны быть. Из-за того, что сопло в начале печати плотно прижимается к печатающему столу, слой начинает немного размазываться. В дальнейшем печать выравнивается, так как не происходит процесса прижатия.\n\nКак бороться:\n\n● Отрегулировать стол\nДля этого нужно отрегулировать положение сопла так, чтобы оно не упиралось в печатающую платформу. Всегда должен оставаться незначительный зазор.\n\n● Уменьшить температуру стола\nНебольшое понижение температуры стола может устранить дефект «Слоновьей ноги». Не стоит использовать данный метод слишком часто, так как это может ухудшить общее качество печати.\n\n● Конструкционные улучшения модели \nДля этого следует добавить маленькие фаски или сопряжения. Если немного поработать с настройками, то модель будет  ровной и красивой. Однако размер фаски точно определить трудно. Начать нужно с фаски размером 0.5×45. После  оптимальный вариант фаски можно найти эмпирическим путем.");
            t.ShowDialog();
        }

        private void buttonScratches_Click(object sender, EventArgs e)
        {
            FormError t = new FormError("Царапины", "Часто используемое описание: Царапины на поверхности и неравномерность по цвету.\n\nОписание: Во время перемещения печатающая головка оставляет за собой след на пластике вследствие близкого контакта с поверхностью. Это может быть связано с тем, что печатающая головка либо задевает старый пластик, либо размазывает новый. При этом и в первом, и во втором случае пластик будет вытекать из сопла из-за контакта.\n\nКак бороться:\n\n● Увеличение скорости и понижение температуры\nКогда пластик оставляет след, увеличение скорости и  понижение температуры могут снизить эффект от данной проблемы.\n\n● Изменение настроек слайсера\nВ большой степени данный дефект можно контролировать слайсером. Например, если стоит слайсер «Cura», то можно использовать функцию «z-hop», которая приподнимает сопло.Кроме того, можно поработать с функцией «retract».\n\n● Изменение геометрии\nДанный дефект может также проявляться на сложных поверхностях. Можно добавить ровный слой на модель или в целом упростить геометрию.");
            t.ShowDialog();
        }
    }
}
