using System;
using System.Collections.Generic;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Model
{
    public class ListBodyModel<T> where T : class
    {
        public IEnumerable<T> Data { get; set; }
        public DateTime Requested {
            get {
                return DateTime.Now;
            }
        }

        public static ListBodyModel<T> ToBodyList(IEnumerable<T> list)
        {
            ListBodyModel<T> listModel = new ListBodyModel<T>();
            listModel.Data = list;
            return listModel;
        }
    }
}
