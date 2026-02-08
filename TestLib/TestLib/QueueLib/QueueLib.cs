namespace TestLib.QueueLib;
using Unit4.CollectionsLib;

public class QueueLib
{
    // מחזיר את האיבר לפי אינדקס. -1 מחזיר את האחרון
    // מקבלת: תור, אינדקס
    // מחזירה/עושה: הערך המבוקש מהתור
    // סיבוכיות: O(n)
    // הערות: מתעדכן לתור המקורי לאחר קריאה
    public static T Get_By_Index_Queue<T>(Queue<T> q, int index)
    {
        if (q.IsEmpty())
            return default(T) ?? throw new InvalidOperationException();

        Queue<T> temp = new Queue<T>(); // תור זמני לשחזור
        T result = default(T)!;         // התוצאה
        T lastItem = default(T)!;       // האיבר האחרון
        int count = 0;                  
        bool found = false;

        while (!q.IsEmpty())
        {
            T current = q.Remove();

            // בדיקה אם זה האינדקס המבוקש
            if (count == index)
            {
                result = current;
                found = true;
            }

            lastItem = current;       // תמיד שומרים את האחרון
            temp.Insert(current);     // שמירה בתור זמני
            count++;
        }

        // שחזור התור המקורי
        while (!temp.IsEmpty())
            q.Insert(temp.Remove());

        if (index == -1) return lastItem;
        if (!found) return default(T)!;

        return result;
    }

    // מחליף איבר בתור לפי אינדקס
    // מקבלת: תור, אינדקס, ערך חדש
    // מחזירה/עושה: מחליפה את הערך בתור
    // סיבוכיות: O(n)
    // הערות: אם האינדקס לא קיים, התור נשאר ללא שינוי
    public static void Set_By_Index_Queue<T>(Queue<T> q, int index, T newValue)
    {
        if (q.IsEmpty()) return;

        Queue<T> temp = new Queue<T>();
        int count = 0;

        while (!q.IsEmpty())
        {
            T current = q.Remove();

            if (count == index)
            {
                temp.Insert(newValue); // מחליפים את האיבר במקום
            }
            else temp.Insert(current);

            count++;
        }

        // שחזור התור המקורי
        while (!temp.IsEmpty())
            q.Insert(temp.Remove());
    }

    // מחזיר את אורך התור
    // מקבלת: תור
    // מחזירה/עושה: מספר האיברים בתור
    // סיבוכיות: O(n)
    // הערות: מתעדכן לתור המקורי לאחר ספירה
    public static int LenghtQ<T>(Queue<T> q)
    {
        Queue<T> temp = new Queue<T>();
        int count = 0;

        while (!q.IsEmpty())
        {
            temp.Insert(q.Remove());
            count++;
        }

        while (!temp.IsEmpty())
            q.Insert(temp.Remove());

        return count;
    }

    // מחזיר עותק של התור
    // מקבלת: תור
    // מחזירה/עושה: עותק של התור
    // סיבוכיות: O(n)
    // הערות: התור המקורי נשאר ללא שינוי
    public static Queue<T> CopyQ<T>(Queue<T> q)
    {
        Queue<T> newQ = new Queue<T>();
        Queue<T> temp = new Queue<T>();

        while (!q.IsEmpty())
        {
            T item = q.Remove();
            newQ.Insert(item);
            temp.Insert(item); // לשחזור התור המקורי
        }

        while (!temp.IsEmpty())
            q.Insert(temp.Remove());

        return newQ;
    }

    // בודק אם איבר קיים בתור
    // מקבלת: תור, ערך לחיפוש
    // מחזירה/עושה: true אם הערך קיים בתור, אחרת false
    // סיבוכיות: O(n)
    // הערות: התור נשאר ללא שינוי
    public static bool DoesExistQ<TT>(Queue<TT> q, TT value)
    {
        Queue<TT> temp = new Queue<TT>();
        bool found = false;

        while (!q.IsEmpty())
        {
            TT item = q.Remove();

            if (item!.Equals(value)) found = true; // בדיקה שווה
            temp.Insert(item);                     // שמירה לתור זמני
        }

        while (!temp.IsEmpty())
            q.Insert(temp.Remove());

        return found;
    }

    // בודק אם שני תורים זהים בגודל ובסדר
    // מקבלת: תור ראשון, תור שני
    // מחזירה/עושה: true אם זהים, אחרת false
    // סיבוכיות: O(n)
    // הערות: מחזיר false אם מספר האיברים שונה או סדר שונה
    public static bool IsIdentical<TT>(Queue<TT> q1, Queue<TT> q2)
    {
        Queue<TT> temp1 = new Queue<TT>();
        Queue<TT> temp2 = new Queue<TT>();
        bool identical = true;

        while (identical && !(q1.IsEmpty() && q2.IsEmpty()))
        {
            if (q1.IsEmpty() || q2.IsEmpty())
            {
                identical = false; // מספר שונה של איברים
            }
            else
            {
                TT item1 = q1.Remove();
                TT item2 = q2.Remove();

                if (!item1!.Equals(item2)) identical = false;

                temp1.Insert(item1);
                temp2.Insert(item2);
            }
        }

        while (!temp1.IsEmpty())
            q1.Insert(temp1.Remove());
        while (!temp2.IsEmpty())
            q2.Insert(temp2.Remove());

        return identical;
    }

    // מוסיף ערך במיקום מסוים בתור
    // מקבלת: תור, אינדקס, ערך חדש
    // מחזירה/עושה: מוסיפה את הערך במקום המבוקש
    // סיבוכיות: O(n)
    // הערות: אם אינדקס = -1, מוסיפה בסוף התור
    public static void Insert_To_Index_Queue<T>(Queue<T> q, int index, T newValue)
    {
        if (q.IsEmpty() && index == 0)
        {
            q.Insert(newValue);
            return;
        }
        else if (q.IsEmpty())
        {
            return;
        }

        Queue<T> temp = new Queue<T>();
        int count = 0;
        bool inserted = false;

        while (!q.IsEmpty())
        {
            T current = q.Remove();

            if (count == index)
            {
                temp.Insert(newValue); // הכנסת הערך החדש במקום הנכון
                inserted = true;
            }

            temp.Insert(current); // שמירת הערך הנוכחי
            count++;
        }

        // אם היינו צריכים להכניס בסוף התור
        if (!inserted && (count == index || index == -1))
        {
            temp.Insert(newValue);
        }

        // החזרת האיברים לתור המקורי
        while (!temp.IsEmpty())
        {
            q.Insert(temp.Remove());
        }
    }
}
