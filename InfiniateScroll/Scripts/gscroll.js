//Constructor params are all needed except loadingContainer and sortOrder
function Gscroll(itemsPerPage, oDataUrl, templateId, containerId, loadingContainer, sortOrder)
{
    var currentPage = 1;
    var allPagesLoaded = false;

    var readyForNextPage = function () {
        var first = $(window).scrollTop();
        var second = $(document).height() - $(window).height();
        var atBottom = first > second ? first - second : second - first;
        return (atBottom < 10 && !allPagesLoaded);
    }

    var renderPageToTemplate = function (data) {
        if (data == "") {
            $("#" + loadingContainer).hide();
            allPagesLoaded = true;
        }
        else {
            $("#" + templateId).tmpl(eval(data)).appendTo("#" + containerId);
            currentPage++;
            loadNextPage();
        }
    }

    var loadNextPage = function () {
        if (readyForNextPage()) {
            if (loadingContainer)
                $("#" + loadingContainer).show();
            //Build the OData URL
            var url = oDataUrl +
                '?$skip=' + (itemsPerPage * (currentPage - 1)).toString() +
                '&$top=' + itemsPerPage.toString();
            if (sortOrder) 
                url += '&$orderby=' + sortOrder + ' ' + sortDirection;
            //Get Page From Server
            $.get(url, null, function (data) { renderPageToTemplate(data); });
        }
        else {
            if (loadingContainer)
                $("#" + loadingContainer).hide();
        }
    }

    $(window).scroll(loadNextPage);
    loadNextPage();

}