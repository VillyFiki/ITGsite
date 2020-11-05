using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAuth.Models
{
    public static class TestArticleData
    {
        public static string Article1 = @"<p><b>Вывод списка закупок, в которых были произведены обновления за последние n дней у определенного заказчика</b></p>


                Параметры запроса(включаются в адресную строку):
                <ul>
                    <li>late – задается период времени;</li>
                    <li>inn и kpp – задается конкретный заказчик.</li>
                </ul>

                Пример:
                <div class=""gray"">Есть запрос https://etp.gpb.ru/api/procedures.php?inn=7724514910&kpp=772801001&late=10 </div>
                который отправляет данные об ИНН, КПП и о периоде времени(в днях), а в ответ получает список закупок указанного заказчика.Ответ будет отправлен в формате XML.
                Список полей в xml документе:
                <ul>
                    <li>registry_number Реестровый номер процедуры;</li>
                    <li>Number Номер лота в рамках соответствующей процедуры;</li>
                    <li>Status Статус лота;</li>
                </ul>

";
        public static string Article2 = @"                <p><b>Вывод списка закупок, в которых были произведены обновления за последние n дней</b></p>


                Параметры запроса (включаются в адресную строку):
                <ul>
                    <li>late – задается период времени;</li>
                </ul>

                Пример:
                <div class=""gray"">
                    Есть запрос  https://etp.gpb.ru/api/company_list.php?late=1
                </div>
                который отправляет данные о периоде времени(в днях), а в ответ получает список закупок всех заказчиков.Ответ будет отправлен в формате XML.

                Список полей в xml документе:
                <ul>
                    <li>id Идентификатор организации;</li>
                    <li>inn ИНН организации;</li>
                    <li>cpp КПП организации;</li>
                    <li>date_accept Дата принятия аккредитации в системе.;</li>
                </ul>

";

        public static string Article3 = @"<p><b>Сведения о конкретной организации</b></p>
                

                Можно получить сведения о конкретной организации в виде электронного документа – XML-файла, по запросу HTTP GET одного из двух видов:
                <p>
                    <div class=""gray"">1) https://etp.gpb.ru/api/company.php?id=849</div>
                    Параметры запроса(включаются в адресную строку):
                    <ul>
                        <li>id – задается id организации;</li>

                    </ul>
                    <div class=""gray"">2) https://etp.gpb.ru/api/company.php?inn=7744001497&kpp=997950001</div>
                    Параметры запроса(включаются в адресную строку):
                    <ul>
                        <li>inn – задается инн организации;</li>
                        <li>kpp – задается кпп организации;</li>
                    </ul>
                </p>

                Описание возвращаемых параметров:
                <table>
                    <tr>
                        <td>Организация</td>
                        <td>Наименование поля</td>
                        <td>Описание</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>id</td>
                        <td>
                            идентификатор организации в системе ЭТП
                            ГПБ (внутренний)
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>inn</td>
                        <td>
                            ИНН
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>kpp</td>
                        <td>КПП</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>ogrn</td>
                        <td>ОГРН</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>full_name</td>
                        <td>полное наименование организации</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>short_name</td>
                        <td>
                            сокращенное наименование организации
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>phone</td>
                        <td>
                            контактный телефон
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>fax</td>
                        <td>факс</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>email</td>
                        <td>контактный e-mail</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>addr_main</td>
                        <td>юридический адрес</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>addr_post</td>
                        <td>почтовый адрес</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>accreditation</td>
                        <td>
                            дата аккредитации. Аттрибут type
                            определяет тип аккредитации: «customer»,
                            «supplier»
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>date_last_update</td>
                        <td>
                            дата последнего изменения данных
                            организации
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>region</td>
                        <td>регион организации</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>profile</td>
                        <td>
                            название профиля. Аттрибут type
                            определяет тип профиля: «customer» или
                            «supplier»
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>acct_kor</td>
                        <td>
                            номер коррепондентского счета
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>bik</td>
                        <td>БИК банка</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>bank</td>
                        <td>наименование банка</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>bank_addr</td>
                        <td>
                            адрес банка
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>files</td>
                        <td>
                            документы организации, может быть
                            множественным
                        </td>
                    </tr>
                    <tr>
                        <td>files</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>file</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>file</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>customer</td>
                        <td>
                            документы организации аккредитованной в
                            качестве заказчика
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>supplier</td>
                        <td>
                            документы организации аккредитованной в
                            качестве заявителя
                        </td>
                    </tr>
                </table>


                <p> Описание атрибутов документов организации: </p>
                <ul>
                    <li>Атрибут Descr – описание документа;</li>
                    <li>Атрибут Date – дата добавления документа в систему;</li>
                    <li>Атрибут HASH – хэш код файла.</li>
                </ul>
";

        public static string Article4 = @"                <p><b>Вывод cписка протоколов</b></p>

                Получить список протоколов, опубликованных за прошедшие   сутки в системе коммерческих закупок ЭТП ГПБ, в виде электронного документа – XMLфайла со следующими полями:
                <protocol registry_number=""REGISTRY_NUMBER"" count=""COUNT"">
                    где
                    <ul>
                        <li>registry_number – реестровый номер аукциона</li>
                        <li>count –кол-во протоколов</li>
                    </ul>

                    По HTTP GET запросу вида:
                    <div class=""gray""> https://etp.gpb.ru/api/protocols_list.php?updatedonly </div>
                    который отправляет данные об ИНН, КПП и о периоде времени(в днях), а в ответ получает список закупок указанного заказчика.Ответ будет отправлен в формате XML.
";

        public static string Article5 = @"                <p><b>Информация о протоколах конкретной процедуры</b></p>

        Внешняя АИС может получить информацию о протоколах процедуры в виде
        электронного документа – XML-файла, с помощью запроса HTTP GET вида
        <div class=""gray"">https://etp.gpb.ru/api/protocols.php?num=ГП410451</div>
        где num – регистрационный номер процедуры.

        Протоколы отображаются по лотам.Для лота указаны:
        <ul>
            <li>id – идентификатор лота в коммерческой системе;</li>
            <li>lot_no – номер лота.</li>
        </ul>
        Описание атрибутов протоколов:
        <ul>
            <li>TYPE – тип протокола.</li>
        </ul>
";
        
    }
}
