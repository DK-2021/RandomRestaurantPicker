using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataModels.Generated
{

    public class Rootobject
    {
        public Datum[] data { get; set; }
        public Filters filters { get; set; }
        public Filters_V2 filters_v2 { get; set; }
        public Restaurant_Availability_Options restaurant_availability_options { get; set; }
        public Open_Hours_Options open_hours_options { get; set; }
        public Paging paging { get; set; }
    }

    public class Filters
    {
        public Rac_Deals_Only rac_deals_only { get; set; }
        public Rating rating { get; set; }
        public Restaurant_Mealtype restaurant_mealtype { get; set; }
        public Exclude_Locations exclude_locations { get; set; }
        public Dietary_Restrictions dietary_restrictions { get; set; }
        public Rsrv rsrv { get; set; }
        public Restaurant_Tagcategory restaurant_tagcategory { get; set; }
        public Open_Now open_now { get; set; }
        public Min_Rating min_rating { get; set; }
        public Neighborhood neighborhood { get; set; }
        public Subcategory subcategory { get; set; }
        public Prices_Restaurants prices_restaurants { get; set; }
        public Restaurant_Dining_Options restaurant_dining_options { get; set; }
        public Restaurant_Tagcategory_Standalone restaurant_tagcategory_standalone { get; set; }
        public Restaurant_Styles restaurant_styles { get; set; }
        public Combined_Food combined_food { get; set; }
    }

    public class Rac_Deals_Only
    {
        public False _false { get; set; }
        public True _true { get; set; }
    }

    public class False
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class True
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class Rating
    {
        public All all { get; set; }
        public _1 _1 { get; set; }
        public _2 _2 { get; set; }
        public _3 _3 { get; set; }
        public _4 _4 { get; set; }
        public _5 _5 { get; set; }
    }

    public class All
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class _1
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class _2
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class _3
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class _4
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class _5
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class Restaurant_Mealtype
    {
        public All1 all { get; set; }
        public _10606 _10606 { get; set; }
        public _10598 _10598 { get; set; }
        public _10597 _10597 { get; set; }
        public _10599 _10599 { get; set; }
    }

    public class All1
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10606
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10598
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10597
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10599
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class Exclude_Locations
    {
        public Filtered filtered { get; set; }
        public All2 all { get; set; }
    }

    public class Filtered
    {
        public string count { get; set; }
        public string label { get; set; }
    }

    public class All2
    {
        public string count { get; set; }
        public string label { get; set; }
    }

    public class Dietary_Restrictions
    {
        public All3 all { get; set; }
        public _10992 _10992 { get; set; }
        public _10697 _10697 { get; set; }
        public _10665 _10665 { get; set; }
    }

    public class All3
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10992
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10697
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10665
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class Rsrv
    {
        public False1 _false { get; set; }
        public True1 _true { get; set; }
    }

    public class False1
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class True1
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class Restaurant_Tagcategory
    {
        public All4 all { get; set; }
        public _9909 _9909 { get; set; }
        public _21908 _21908 { get; set; }
        public _10591 _10591 { get; set; }
        public _9900 _9900 { get; set; }
        public _16556 _16556 { get; set; }
        public _9901 _9901 { get; set; }
        public _11776 _11776 { get; set; }
        public _16548 _16548 { get; set; }
    }

    public class All4
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _9909
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21908
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10591
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _9900
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _16556
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _9901
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _11776
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _16548
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class Open_Now
    {
        public False2 _false { get; set; }
        public True2 _true { get; set; }
    }

    public class False2
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class True2
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class Min_Rating
    {
        public _31 _3 { get; set; }
        public _41 _4 { get; set; }
        public _51 _5 { get; set; }
    }

    public class _31
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class _41
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class _51
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class Neighborhood
    {
        public _20483749 _20483749 { get; set; }
        public _20483748 _20483748 { get; set; }
        public _20933768 _20933768 { get; set; }
    }

    public class _20483749
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class _20483748
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class _20933768
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class Subcategory
    {
        public All5 all { get; set; }
        public Sit_Down sit_down { get; set; }
        public Cafe cafe { get; set; }
        public Fast_Food fast_food { get; set; }
    }

    public class All5
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class Sit_Down
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class Cafe
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class Fast_Food
    {
        public string count { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class Prices_Restaurants
    {
        public All6 all { get; set; }
        public _10954 _10954 { get; set; }
        public _10953 _10953 { get; set; }
        public _10955 _10955 { get; set; }
    }

    public class All6
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10954
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10953
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10955
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class Restaurant_Dining_Options
    {
        public All7 all { get; set; }
        public _21379 _21379 { get; set; }
        public _20992 _20992 { get; set; }
        public _11780 _11780 { get; set; }
        public _20989 _20989 { get; set; }
        public _20996 _20996 { get; set; }
        public _10602 _10602 { get; set; }
        public _10854 _10854 { get; set; }
        public _10612 _10612 { get; set; }
        public _10601 _10601 { get; set; }
        public _10702 _10702 { get; set; }
        public _10603 _10603 { get; set; }
        public _10859 _10859 { get; set; }
        public _21907 _21907 { get; set; }
        public _16547 _16547 { get; set; }
        public _10870 _10870 { get; set; }
        public _10862 _10862 { get; set; }
        public _10861 _10861 { get; set; }
        public _10600 _10600 { get; set; }
    }

    public class All7
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21379
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20992
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _11780
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20989
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20996
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10602
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10854
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10612
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10601
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10702
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10603
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10859
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21907
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _16547
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10870
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10862
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10861
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10600
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class Restaurant_Tagcategory_Standalone
    {
        public All8 all { get; set; }
        public _99091 _9909 { get; set; }
        public _219081 _21908 { get; set; }
        public _105911 _10591 { get; set; }
        public _99001 _9900 { get; set; }
        public _165561 _16556 { get; set; }
        public _99011 _9901 { get; set; }
        public _117761 _11776 { get; set; }
        public _165481 _16548 { get; set; }
    }

    public class All8
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _99091
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _219081
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _105911
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _99001
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _165561
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _99011
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _117761
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _165481
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class Restaurant_Styles
    {
        public All9 all { get; set; }
        public _16550 _16550 { get; set; }
        public _10613 _10613 { get; set; }
        public _10604 _10604 { get; set; }
        public _12504 _12504 { get; set; }
        public _10614 _10614 { get; set; }
        public _10605 _10605 { get; set; }
        public _10608 _10608 { get; set; }
        public _10607 _10607 { get; set; }
        public _10609 _10609 { get; set; }
        public _11777 _11777 { get; set; }
        public _10610 _10610 { get; set; }
    }

    public class All9
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _16550
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10613
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10604
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _12504
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10614
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10605
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10608
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10607
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10609
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _11777
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10610
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class Combined_Food
    {
        public _20335 _20335 { get; set; }
        public _20697 _20697 { get; set; }
        public _20333 _20333 { get; set; }
        public _21301 _21301 { get; set; }
        public _20331 _20331 { get; set; }
        public _20339 _20339 { get; set; }
        public _20699 _20699 { get; set; }
        public _20336 _20336 { get; set; }
        public _10899 _10899 { get; set; }
        public _10898 _10898 { get; set; }
        public _10659 _10659 { get; set; }
        public _10779 _10779 { get; set; }
        public _5379 _5379 { get; set; }
        public _10891 _10891 { get; set; }
        public _10772 _10772 { get; set; }
        public _10651 _10651 { get; set; }
        public _10893 _10893 { get; set; }
        public _10892 _10892 { get; set; }
        public _10653 _10653 { get; set; }
        public _10774 _10774 { get; set; }
        public _10894 _10894 { get; set; }
        public _10655 _10655 { get; set; }
        public _10654 _10654 { get; set; }
        public _10896 _10896 { get; set; }
        public _20344 _20344 { get; set; }
        public _20341 _20341 { get; set; }
        public _20460 _20460 { get; set; }
        public _20349 _20349 { get; set; }
        public _10668 _10668 { get; set; }
        public _4617 _4617 { get; set; }
        public _10669 _10669 { get; set; }
        public _10660 _10660 { get; set; }
        public _10661 _10661 { get; set; }
        public _10785 _10785 { get; set; }
        public _10664 _10664 { get; set; }
        public _10666 _10666 { get; set; }
        public _20312 _20312 { get; set; }
        public _20554 _20554 { get; set; }
        public _20553 _20553 { get; set; }
        public _20552 _20552 { get; set; }
        public _20319 _20319 { get; set; }
        public _20318 _20318 { get; set; }
        public _20317 _20317 { get; set; }
        public _20316 _20316 { get; set; }
        public _20315 _20315 { get; set; }
        public _20556 _20556 { get; set; }
        public _20314 _20314 { get; set; }
        public _10635 _10635 { get; set; }
        public _10756 _10756 { get; set; }
        public _10877 _10877 { get; set; }
        public _10634 _10634 { get; set; }
        public _10876 _10876 { get; set; }
        public _10755 _10755 { get; set; }
        public _10879 _10879 { get; set; }
        public _10758 _10758 { get; set; }
        public _10757 _10757 { get; set; }
        public _10878 _10878 { get; set; }
        public _11725 _11725 { get; set; }
        public _10639 _10639 { get; set; }
        public _10752 _10752 { get; set; }
        public _10872 _10872 { get; set; }
        public _11722 _11722 { get; set; }
        public _10875 _10875 { get; set; }
        public _10632 _10632 { get; set; }
        public _10874 _10874 { get; set; }
        public _11721 _11721 { get; set; }
        public _20324 _20324 { get; set; }
        public _20321 _20321 { get; set; }
        public _20320 _20320 { get; set; }
        public _9899 _9899 { get; set; }
        public _20561 _20561 { get; set; }
        public _20560 _20560 { get; set; }
        public _20325 _20325 { get; set; }
        public _10646 _10646 { get; set; }
        public _10766 _10766 { get; set; }
        public _10887 _10887 { get; set; }
        public _10645 _10645 { get; set; }
        public _10648 _10648 { get; set; }
        public _10647 _10647 { get; set; }
        public _10649 _10649 { get; set; }
        public _11738 _11738 { get; set; }
        public _10640 _10640 { get; set; }
        public _10760 _10760 { get; set; }
        public _10881 _10881 { get; set; }
        public _10642 _10642 { get; set; }
        public _10884 _10884 { get; set; }
        public _10763 _10763 { get; set; }
        public _10641 _10641 { get; set; }
        public _10883 _10883 { get; set; }
        public _10886 _10886 { get; set; }
        public _10643 _10643 { get; set; }
        public _10885 _10885 { get; set; }
        public _20533 _20533 { get; set; }
        public _20532 _20532 { get; set; }
        public _20535 _20535 { get; set; }
        public _20534 _20534 { get; set; }
        public _10616 _10616 { get; set; }
        public _10618 _10618 { get; set; }
        public _21184 _21184 { get; set; }
        public _20544 _20544 { get; set; }
        public _20542 _20542 { get; set; }
        public _20549 _20549 { get; set; }
        public _20547 _20547 { get; set; }
        public _20546 _20546 { get; set; }
        public _20545 _20545 { get; set; }
        public _10744 _10744 { get; set; }
        public _10626 _10626 { get; set; }
        public _10749 _10749 { get; set; }
        public _11717 _11717 { get; set; }
        public _10748 _10748 { get; set; }
        public _21072 _21072 { get; set; }
        public _21071 _21071 { get; set; }
        public _21191 _21191 { get; set; }
        public _10740 _10740 { get; set; }
        public _10622 _10622 { get; set; }
        public _10621 _10621 { get; set; }
        public _10742 _10742 { get; set; }
        public _5086 _5086 { get; set; }
        public _20752 _20752 { get; set; }
        public _20077 _20077 { get; set; }
        public _21045 _21045 { get; set; }
        public _20075 _20075 { get; set; }
        public _21285 _21285 { get; set; }
        public _20754 _20754 { get; set; }
        public _21040 _21040 { get; set; }
        public _20191 _20191 { get; set; }
        public _21055 _21055 { get; set; }
        public _21175 _21175 { get; set; }
        public _10722 _10722 { get; set; }
        public _10727 _10727 { get; set; }
        public _21174 _21174 { get; set; }
        public _21293 _21293 { get; set; }
        public _20730 _20730 { get; set; }
        public _20179 _20179 { get; set; }
        public _20178 _20178 { get; set; }
        public _20177 _20177 { get; set; }
        public _20176 _20176 { get; set; }
        public _21023 _21023 { get; set; }
        public _21022 _21022 { get; set; }
        public _20174 _20174 { get; set; }
        public _10928 _10928 { get; set; }
        public _20737 _20737 { get; set; }
        public _20733 _20733 { get; set; }
        public _10932 _10932 { get; set; }
        public _10931 _10931 { get; set; }
        public _10934 _10934 { get; set; }
        public _10933 _10933 { get; set; }
        public _10936 _10936 { get; set; }
        public _10935 _10935 { get; set; }
        public _10937 _10937 { get; set; }
        public _20173 _20173 { get; set; }
        public _20172 _20172 { get; set; }
        public _10930 _10930 { get; set; }
        public _21038 _21038 { get; set; }
        public _20740 _20740 { get; set; }
        public _21037 _21037 { get; set; }
        public _20189 _20189 { get; set; }
        public _20188 _20188 { get; set; }
        public _21277 _21277 { get; set; }
        public _20066 _20066 { get; set; }
        public _20187 _20187 { get; set; }
        public _21275 _21275 { get; set; }
        public _20185 _20185 { get; set; }
        public _10939 _10939 { get; set; }
        public _20505 _20505 { get; set; }
        public _10700 _10700 { get; set; }
        public _10942 _10942 { get; set; }
        public _9908 _9908 { get; set; }
        public _10944 _10944 { get; set; }
        public _20184 _20184 { get; set; }
        public _20183 _20183 { get; set; }
        public _20182 _20182 { get; set; }
        public _21270 _21270 { get; set; }
        public _20181 _20181 { get; set; }
        public _20180 _20180 { get; set; }
        public _10941 _10941 { get; set; }
        public _10940 _10940 { get; set; }
        public _20038 _20038 { get; set; }
        public _20037 _20037 { get; set; }
        public _20158 _20158 { get; set; }
        public _21367 _21367 { get; set; }
        public _20036 _20036 { get; set; }
        public _20035 _20035 { get; set; }
        public _20156 _20156 { get; set; }
        public _21002 _21002 { get; set; }
        public _20034 _20034 { get; set; }
        public _19960 _19960 { get; set; }
        public _20031 _20031 { get; set; }
        public _10907 _10907 { get; set; }
        public _20716 _20716 { get; set; }
        public _10909 _10909 { get; set; }
        public _10908 _10908 { get; set; }
        public _21009 _21009 { get; set; }
        public _20711 _20711 { get; set; }
        public _20039 _20039 { get; set; }
        public _10910 _10910 { get; set; }
        public _10911 _10911 { get; set; }
        public _10914 _10914 { get; set; }
        public _10916 _10916 { get; set; }
        public _10915 _10915 { get; set; }
        public _20030 _20030 { get; set; }
        public _20150 _20150 { get; set; }
        public _9911 _9911 { get; set; }
        public _21017 _21017 { get; set; }
        public _21378 _21378 { get; set; }
        public _20168 _20168 { get; set; }
        public _20167 _20167 { get; set; }
        public _20045 _20045 { get; set; }
        public _20166 _20166 { get; set; }
        public _20044 _20044 { get; set; }
        public _20165 _20165 { get; set; }
        public _20164 _20164 { get; set; }
        public _20043 _20043 { get; set; }
        public _20042 _20042 { get; set; }
        public _20163 _20163 { get; set; }
        public _10918 _10918 { get; set; }
        public _10919 _10919 { get; set; }
        public _20723 _20723 { get; set; }
        public _10921 _10921 { get; set; }
        public _10923 _10923 { get; set; }
        public _10922 _10922 { get; set; }
        public _10924 _10924 { get; set; }
        public _10927 _10927 { get; set; }
        public _10926 _10926 { get; set; }
        public _20162 _20162 { get; set; }
        public _20041 _20041 { get; set; }
        public _20040 _20040 { get; set; }
        public _20161 _20161 { get; set; }
        public _20137 _20137 { get; set; }
        public _20136 _20136 { get; set; }
        public _20135 _20135 { get; set; }
        public _20134 _20134 { get; set; }
        public _21223 _21223 { get; set; }
        public _20497 _20497 { get; set; }
        public _16554 _16554 { get; set; }
        public _20133 _20133 { get; set; }
        public _16553 _16553 { get; set; }
        public _20131 _20131 { get; set; }
        public _20130 _20130 { get; set; }
        public _20139 _20139 { get; set; }
        public _20138 _20138 { get; set; }
        public _10692 _10692 { get; set; }
        public _10695 _10695 { get; set; }
        public _16555 _16555 { get; set; }
        public _10698 _10698 { get; set; }
        public All10 all { get; set; }
        public _20027 _20027 { get; set; }
        public _20148 _20148 { get; set; }
        public _21237 _21237 { get; set; }
        public _20026 _20026 { get; set; }
        public _20025 _20025 { get; set; }
        public _19953 _19953 { get; set; }
        public _5110 _5110 { get; set; }
        public _21355 _21355 { get; set; }
        public _5473 _5473 { get; set; }
        public _20145 _20145 { get; set; }
        public _20024 _20024 { get; set; }
        public _21354 _21354 { get; set; }
        public _20144 _20144 { get; set; }
        public _21353 _21353 { get; set; }
        public _20141 _20141 { get; set; }
        public _20706 _20706 { get; set; }
        public _20704 _20704 { get; set; }
        public _20703 _20703 { get; set; }
        public _21239 _21239 { get; set; }
        public _20700 _20700 { get; set; }
        public _20029 _20029 { get; set; }
        public _10348 _10348 { get; set; }
        public _10901 _10901 { get; set; }
        public _10900 _10900 { get; set; }
        public _10902 _10902 { get; set; }
        public _10905 _10905 { get; set; }
        public _20140 _20140 { get; set; }
        public _19959 _19959 { get; set; }
        public _19958 _19958 { get; set; }
        public _10345 _10345 { get; set; }
        public _19955 _19955 { get; set; }
        public _19954 _19954 { get; set; }
        public _10346 _10346 { get; set; }
        public _21324 _21324 { get; set; }
        public _20112 _20112 { get; set; }
        public _21201 _21201 { get; set; }
        public _21320 _21320 { get; set; }
        public _21209 _21209 { get; set; }
        public _21326 _21326 { get; set; }
        public _10679 _10679 { get; set; }
        public _10678 _10678 { get; set; }
        public _10671 _10671 { get; set; }
        public _10670 _10670 { get; set; }
        public _10675 _10675 { get; set; }
        public _10676 _10676 { get; set; }
        public _20126 _20126 { get; set; }
        public _21215 _21215 { get; set; }
        public _20125 _20125 { get; set; }
        public _20124 _20124 { get; set; }
        public _20485 _20485 { get; set; }
        public _20483 _20483 { get; set; }
        public _21219 _21219 { get; set; }
        public _20129 _20129 { get; set; }
        public _10682 _10682 { get; set; }
        public _10681 _10681 { get; set; }
        public _10683 _10683 { get; set; }
        public _10686 _10686 { get; set; }
        public _10685 _10685 { get; set; }
        public _10687 _10687 { get; set; }
    }

    public class _20335
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20697
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20333
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21301
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20331
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20339
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20699
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20336
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10899
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10898
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10659
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10779
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _5379
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10891
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10772
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10651
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10893
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10892
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10653
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10774
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10894
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10655
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10654
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10896
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20344
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20341
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20460
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20349
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10668
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _4617
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10669
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10660
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10661
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10785
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10664
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10666
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20312
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20554
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20553
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20552
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20319
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20318
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20317
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20316
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20315
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20556
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20314
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10635
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10756
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10877
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10634
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10876
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10755
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10879
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10758
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10757
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10878
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _11725
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10639
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10752
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10872
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _11722
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10875
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10632
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10874
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _11721
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20324
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20321
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20320
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _9899
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20561
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20560
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20325
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10646
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10766
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10887
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10645
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10648
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10647
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10649
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _11738
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10640
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10760
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10881
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10642
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10884
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10763
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10641
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10883
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10886
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10643
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10885
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20533
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20532
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20535
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20534
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10616
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10618
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21184
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20544
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20542
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20549
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20547
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20546
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20545
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10744
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10626
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10749
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _11717
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10748
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21072
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21071
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21191
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10740
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10622
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10621
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10742
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _5086
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20752
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20077
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21045
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20075
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21285
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20754
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21040
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20191
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21055
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21175
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10722
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10727
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21174
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21293
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20730
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20179
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20178
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20177
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20176
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21023
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21022
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20174
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10928
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20737
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20733
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10932
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10931
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10934
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10933
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10936
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10935
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10937
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20173
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20172
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10930
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21038
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20740
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21037
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20189
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20188
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21277
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20066
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20187
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21275
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20185
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10939
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20505
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10700
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10942
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _9908
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10944
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20184
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20183
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20182
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21270
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20181
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20180
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10941
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10940
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20038
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20037
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20158
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21367
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20036
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20035
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20156
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21002
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20034
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _19960
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20031
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10907
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20716
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10909
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10908
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21009
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20711
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20039
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10910
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10911
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10914
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10916
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10915
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20030
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20150
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _9911
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21017
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21378
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20168
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20167
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20045
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20166
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20044
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20165
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20164
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20043
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20042
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20163
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10918
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10919
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20723
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10921
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10923
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10922
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10924
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10927
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10926
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20162
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20041
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20040
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20161
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20137
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20136
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20135
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20134
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21223
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20497
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _16554
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20133
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _16553
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20131
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20130
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20139
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20138
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10692
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10695
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _16555
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10698
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class All10
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20027
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20148
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21237
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20026
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20025
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _19953
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _5110
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21355
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _5473
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20145
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20024
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21354
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20144
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21353
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20141
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20706
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20704
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20703
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21239
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20700
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20029
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10348
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10901
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10900
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10902
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10905
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20140
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _19959
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _19958
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10345
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _19955
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _19954
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10346
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21324
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20112
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21201
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21320
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21209
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21326
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10679
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10678
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10671
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10670
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10675
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10676
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20126
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21215
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20125
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20124
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20485
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20483
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _21219
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _20129
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10682
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10681
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10683
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10686
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10685
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class _10687
    {
        public string count { get; set; }
        public string label { get; set; }
        public string locale_independent_label { get; set; }
        public string priority { get; set; }
        public bool selected { get; set; }
    }

    public class Filters_V2
    {
        public Search_Filters[] search_filters { get; set; }
        public Filter_Sections[] filter_sections { get; set; }
        public Metadata metadata { get; set; }
    }

    public class Metadata
    {
        public string sort { get; set; }
    }

    public class Search_Filters
    {
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Filter_Sections
    {
        public string label { get; set; }
        public string section_id { get; set; }
        public Filter_Groups[] filter_groups { get; set; }
    }

    public class Filter_Groups
    {
        public string type { get; set; }
        public string key { get; set; }
        public string tracking_key { get; set; }
        public string label { get; set; }
        public Option[] options { get; set; }
    }

    public class Option
    {
        public string label { get; set; }
        public string value { get; set; }
        public bool selected { get; set; }
        public string count { get; set; }
        public bool _default { get; set; }
        public bool single_select { get; set; }
    }

    public class Restaurant_Availability_Options
    {
        public string day { get; set; }
        public string month { get; set; }
        public string year { get; set; }
        public string hour { get; set; }
        public string minute { get; set; }
        public string people { get; set; }
        public string datestring { get; set; }
        public bool is_default { get; set; }
        public bool is_set { get; set; }
        public bool racable { get; set; }
        public Time_Options time_options { get; set; }
        public People_Options people_options { get; set; }
    }

    public class Time_Options
    {
        public Selected_Option selected_option { get; set; }
        public Option1[] options { get; set; }
    }

    public class Selected_Option
    {
        public string value { get; set; }
        public string display { get; set; }
        public bool selected { get; set; }
    }

    public class Option1
    {
        public string value { get; set; }
        public string display { get; set; }
        public bool? selected { get; set; }
    }

    public class People_Options
    {
        public Selected_Option1 selected_option { get; set; }
        public Option2[] options { get; set; }
    }

    public class Selected_Option1
    {
        public string value { get; set; }
        public string display { get; set; }
        public bool selected { get; set; }
    }

    public class Option2
    {
        public string value { get; set; }
        public string display { get; set; }
        public bool? selected { get; set; }
    }

    public class Open_Hours_Options
    {
        public string closed_count { get; set; }
        public bool is_set { get; set; }
        public string low_coverage_primary_message { get; set; }
        public string timezone { get; set; }
        public string unsure_count { get; set; }
        public string open_count { get; set; }
        public string low_coverage_secondary_message { get; set; }
        public string current_value { get; set; }
    }

    public class Paging
    {
        public string results { get; set; }
        public string total_results { get; set; }
    }

    public class Datum
    {
        public string location_id { get; set; }
        public string name { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string num_reviews { get; set; }
        public string timezone { get; set; }
        public string location_string { get; set; }
        public Photo photo { get; set; }
        public Award[] awards { get; set; }
        public string doubleclick_zone { get; set; }
        public string preferred_map_engine { get; set; }
        public string raw_ranking { get; set; }
        public string ranking_geo { get; set; }
        public string ranking_geo_id { get; set; }
        public string ranking_position { get; set; }
        public string ranking_denominator { get; set; }
        public string ranking_category { get; set; }
        public string ranking { get; set; }
        public object distance { get; set; }
        public object distance_string { get; set; }
        public object bearing { get; set; }
        public string rating { get; set; }
        public bool is_closed { get; set; }
        public string open_now_text { get; set; }
        public bool is_long_closed { get; set; }
        public string price_level { get; set; }
        public string description { get; set; }
        public string web_url { get; set; }
        public string write_review { get; set; }
        public Ancestor[] ancestors { get; set; }
        public Category category { get; set; }
        public Subcategory2[] subcategory { get; set; }
        public string parent_display_name { get; set; }
        public bool is_jfy_enabled { get; set; }
        public object[] nearest_metro_station { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public string email { get; set; }
        public Address_Obj address_obj { get; set; }
        public string address { get; set; }
        public Hours hours { get; set; }
        public bool is_candidate_for_contact_info_suppression { get; set; }
        public Cuisine[] cuisine { get; set; }
        public Dietary_Restrictions1[] dietary_restrictions { get; set; }
        public Establishment_Types[] establishment_types { get; set; }
        public string price { get; set; }
        public Neighborhood_Info[] neighborhood_info { get; set; }
        public string ad_position { get; set; }
        public string ad_size { get; set; }
        public string detail { get; set; }
        public string page_type { get; set; }
        public string mob_ptype { get; set; }
        public Booking booking { get; set; }
        public Reserve_Info reserve_info { get; set; }
    }

    public class Photo
    {
        public Images images { get; set; }
        public bool is_blessed { get; set; }
        public DateTime uploaded_date { get; set; }
        public string caption { get; set; }
        public string id { get; set; }
        public string helpful_votes { get; set; }
        public DateTime published_date { get; set; }
        public User user { get; set; }
    }

    public class Images
    {
        public Small small { get; set; }
        public Thumbnail thumbnail { get; set; }
        public Original original { get; set; }
        public Large large { get; set; }
        public Medium medium { get; set; }
    }

    public class Small
    {
        public string width { get; set; }
        public string url { get; set; }
        public string height { get; set; }
    }

    public class Thumbnail
    {
        public string width { get; set; }
        public string url { get; set; }
        public string height { get; set; }
    }

    public class Original
    {
        public string width { get; set; }
        public string url { get; set; }
        public string height { get; set; }
    }

    public class Large
    {
        public string width { get; set; }
        public string url { get; set; }
        public string height { get; set; }
    }

    public class Medium
    {
        public string width { get; set; }
        public string url { get; set; }
        public string height { get; set; }
    }

    public class User
    {
        public object user_id { get; set; }
        public string member_id { get; set; }
        public string type { get; set; }
    }

    public class Category
    {
        public string key { get; set; }
        public string name { get; set; }
    }

    public class Address_Obj
    {
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string postalcode { get; set; }
    }

    public class Hours
    {
        public Week_Ranges[][] week_ranges { get; set; }
        public string timezone { get; set; }
    }

    public class Week_Ranges
    {
        public int open_time { get; set; }
        public int close_time { get; set; }
    }

    public class Booking
    {
        public string provider { get; set; }
        public string url { get; set; }
    }

    public class Reserve_Info
    {
        public string id { get; set; }
        public string provider { get; set; }
        public string provider_img { get; set; }
        public string url { get; set; }
        public string booking_partner_id { get; set; }
        public bool racable { get; set; }
        public bool api_bookable { get; set; }
        public object timeslots { get; set; }
        public object bestoffer { get; set; }
        public object timeslot_offers { get; set; }
        public string button_text { get; set; }
        public object disclaimer_text { get; set; }
        public object banner_text { get; set; }
    }

    public class Award
    {
        public string award_type { get; set; }
        public string year { get; set; }
        public Images1 images { get; set; }
        public string[] categories { get; set; }
        public string display_name { get; set; }
    }

    public class Images1
    {
        public string small { get; set; }
        public string large { get; set; }
    }

    public class Ancestor
    {
        public Subcategory1[] subcategory { get; set; }
        public string name { get; set; }
        public string abbrv { get; set; }
        public string location_id { get; set; }
    }

    public class Subcategory1
    {
        public string key { get; set; }
        public string name { get; set; }
    }

    public class Subcategory2
    {
        public string key { get; set; }
        public string name { get; set; }
    }

    public class Cuisine
    {
        public string key { get; set; }
        public string name { get; set; }
    }

    public class Dietary_Restrictions1
    {
        public string key { get; set; }
        public string name { get; set; }
    }

    public class Establishment_Types
    {
        public string key { get; set; }
        public string name { get; set; }
    }

    public class Neighborhood_Info
    {
        public string location_id { get; set; }
        public string name { get; set; }
    }

}
