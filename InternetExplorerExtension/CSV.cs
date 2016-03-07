using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.VisualBasic.FileIO;

namespace Pdc.IEStylish
{
    class Csv
    {
        System.Text.Encoding encord = System.Text.Encoding.GetEncoding("Shift_JIS");

        /// <summary>
        /// CSVを読み込みます。
        /// </summary>
        /// <param name="path">読み込みディレクトリパス</param>
        /// <param name="filename">読み込みファイル名</param>
        /// <returns>読み込んだCSVをDataTableで返却</returns>
        public DataTable CsvReader(string path, string filename)
        {
            string[] data;
            DataTable dt = new DataTable();
            TextFieldParser parser = new TextFieldParser(path + filename, encord);
            parser.TextFieldType = FieldType.Delimited;

            // 区切り文字はコンマ
            parser.SetDelimiters(",");

            //データがあるか確認します。
            if (!parser.EndOfData)
            {
                //CSVファイルから1行読み取ります。
                data = parser.ReadFields();

                //カラムの数を取得します。
                int cols = data.Length;

                for (int i = 0; i < cols; i++)
                {
                    //カラム名をセットします
                    dt.Columns.Add(data[i]);
                }
            }

            // CSVをデータテーブルに格納
            while (!parser.EndOfData)
            {
                data = parser.ReadFields();
                DataRow row = dt.NewRow();

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    row[i] = data[i];
                }

                dt.Rows.Add(row);
            }

            parser.Dispose();
            return dt;
        }
    }
}

