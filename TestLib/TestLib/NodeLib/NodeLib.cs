namespace TestLib.NodeLib;
using Unit4.CollectionsLib;

public class NodeLib
{
    // מחליפה ערך לפי אינדקס. -1 מחליף את האחרון
    // מקבלת: רשימה מקושרת, אינדקס, ערך חדש
    // מחזירה/עושה: משנה את הערך במקום
    // סיבוכיות: O(n)
    public static void Set_By_Index_Node<T>(Node<T> chain, int index, T newValue)
    {
        Node<T> current = chain;
        int count = 0;

        while (current != null)
        {
            // אם הגענו למיקום המבוקש
            if (count == index)
            {
                current.SetValue(newValue);
                return;
            }

            count++;

            // בדיקה מיוחדת אם רוצים את האיבר האחרון
            if (index == -1 && current.GetNext() != null && current.GetNext().GetNext() == null)
            {
                current.GetNext().SetValue(newValue);
                return;
            }

            current = current.GetNext(); // מעבר לאיבר הבא
        }
    }

    // מחזיר ערך לפי אינדקס. -1 מחזיר את האחרון
    // מקבלת: רשימה מקושרת, אינדקס
    // מחזירה/עושה: הערך באינדקס או ברירת מחדל אם לא קיים
    // סיבוכיות: O(n)
    public static T Get_By_Index_Node<T>(Node<T> chain, int index)
    {
        Node<T> current = chain;
        int count = 0;

        while (current != null)
        {
            if (count == index)
                return current.GetValue();

            // בדיקה מיוחדת עבור -1
            if (index == -1 && current.GetNext() != null && current.GetNext().GetNext() == null)
                return current.GetNext().GetValue();

            current = current.GetNext();
            count++;
        }

        return default(T)!; // אם האינדקס גדול מהאורך
    }

    // יוצר רשימה מקושרת ממערך ערכים
    // מקבלת: מערך של int
    // מחזירה/עושה: ראש הרשימה המקושרת
    // סיבוכיות: O(n)
    public static Node<int> CreateList(params int[] values)
    {
        if (values.Length == 0) return null!;

        Node<int> head = new Node<int>(values[0]);
        Node<int> current = head;

        // יצירת שאר האיברים
        for (int i = 1; i < values.Length; i++)
        {
            current.SetNext(new Node<int>(values[i]));
            current = current.GetNext();
        }

        return head;
    }

    // מדפיס רשימה מקושרת
    // מקבלת: ראש הרשימה
    // מחזירה/עושה: מדפיסה למסך את הערכים
    // סיבוכיות: O(n)
    public static void PrintList<TT>(Node<TT>? q)
    {
        if (q == null)
        {
            Console.WriteLine("רשימה ריקה");
            return;
        }

        while (q != null)
        {
            Console.Write(q.GetValue() + " "); // הדפסת הערך הנוכחי
            q = q.GetNext(); // מעבר לאיבר הבא
        }

        Console.WriteLine();
    }

    // מחזיר אורך הרשימה
    // מקבלת: ראש הרשימה
    // מחזירה/עושה: מספר האיברים ברשימה
    // סיבוכיות: O(n)
    public static int LengthLst<T>(Node<T> q)
    {
        int count = 0;

        while (q != null)
        {
            count++;
            q = q.GetNext(); // מעבר לאיבר הבא
        }

        return count;
    }

    // הופך את כיוון הרשימה
    // מקבלת: ראש הרשימה
    // מחזירה/עושה: ראש הרשימה אחרי ההיפוך
    // סיבוכיות: O(n)
    public static Node<TT> Revers<TT>(Node<TT> root)
    {
        Node<TT> prev = null!;
        Node<TT> current = root;

        while (current != null)
        {
            Node<TT> next = current.GetNext(); // שמירת הבא
            current.SetNext(prev); // הפיכת הכיוון
            prev = current; // עדכון prev
            current = next; // מעבר לאיבר הבא
        }

        return prev; // ראש חדש אחרי ההיפוך
    }

    // בודק אם ערך קיים ברשימה
    // מקבלת: ראש הרשימה, ערך לחיפוש
    // מחזירה/עושה: true אם קיים, אחרת false
    // סיבוכיות: O(n)
    public static bool IsExistNode<TT>(Node<TT> head, TT value)
    {
        Node<TT> current = head;

        while (current != null)
        {
            if (current.GetValue()!.Equals(value))
                return true;

            current = current.GetNext(); // מעבר לאיבר הבא
        }

        return false;
    }

    // בודק אם שתי רשימות זהות בגודל ובערכים
    // מקבלת: ראש הרשימה הראשונה, ראש הרשימה השנייה
    // מחזירה/עושה: true אם שוות, אחרת false
    // סיבוכיות: O(n)
    public static bool IsEqualLists<TT>(Node<TT> head1, Node<TT> head2)
    {
        Node<TT> current1 = head1;
        Node<TT> current2 = head2;

        while (current1 != null && current2 != null)
        {
            if (!current1.GetValue()!.Equals(current2.GetValue()))
                return false;

            current1 = current1.GetNext();
            current2 = current2.GetNext();
        }

        return current1 == null && current2 == null; // אמת אם שתיהן נגמרו יחד
    }

    // מוסיף ערך במיקום מסוים ברשימה
    // מקבלת: ראש הרשימה, אינדקס, ערך חדש
    // מחזירה/עושה: מוסיפה את הערך במקום המבוקש
    // סיבוכיות: O(n)
    public static void Insert_To_Index_Node<T>(Node<T> chain, int index, T newValue)
    {
        if (index == 0)
        {
            Node<T> newNode = new Node<T>(newValue);
            newNode.SetNext(chain);
            return;
        }

        Node<T> current = chain;
        int count = 0;

        while (current != null)
        {
            if (count == index - 1)
            {
                Node<T> newNode = new Node<T>(newValue);
                newNode.SetNext(current.GetNext()); // קישור לערך הבא
                current.SetNext(newNode); // הכנסת הערך החדש
                return;
            }

            count++;
            current = current.GetNext();

            // הוספה בסוף אם index = -1
            if (index == -1 && current.GetNext() == null)
            {
                Node<T> newNode = new Node<T>(newValue);
                current.SetNext(newNode);
                return;
            }
        }
    }
}
