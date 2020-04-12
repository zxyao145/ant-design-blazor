using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;

namespace AntBlazor
{
    public class AntPaginationDefaultBase : AntDomComponentBase
    {
        [Parameter] public string Size { get; set; }

        [Parameter] public RenderFragment<PaginationItemRenderContext> ItemRender { get; set; }

        [Parameter] public RenderFragment<PaginationTotalContext> ShowTotal { get; set; }

        [Parameter] public bool Disabled { get; set; }

        [Parameter] public bool ShowSizeChanger { get; set; }

        [Parameter] public bool ShowQuickJumper { get; set; }

        [Parameter] public int Total { get; set; } = 0;

        [Parameter] public int PageIndex { get; set; } = 1;

        [Parameter] public int PageSize { get; set; } = 10;

        [Parameter] public int[] PageSizeOptions { get; set; } = { 10, 20, 30, 40 };

        [Parameter] public EventCallback<int> PageIndexChange { get; set; }

        [Parameter] public EventCallback<int> PageSizeChange { get; set; }

        protected int[] _ranges = { 0, 0 };

        protected IList<AntPaginationItem> _listOfPageItem { get; set; }=new List<AntPaginationItem>();


        protected void jumpPage(int index)
        {

        }

        protected void jumpDiff(int diff)
        {

        }
    }
}