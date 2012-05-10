//Constructor params are all needed except loadingContainer and sortOrder
function Gscroll(itemsPerPage, oDataUrl, templateId, containerId, loadingContainer, sortOrder)
{
    var currentPage = 1;
    var allPagesLoaded = false;
    var loadingPage = false; 

    var readyForNextPage = function () {
        var first = $(window).scrollTop();
        var second = $(document).height() - $(window).height();
        var atBottom = first > second ? first - second : second - first;
        return (atBottom < 3 && !allPagesLoaded && !loadingPage);

    }

    var renderPageToTemplate = function (data) {
        if (data == "") {
            $("#" + loadingContainer).hide();
            allPagesLoaded = true;
            loadingPage = false;
        }
        else {
            $("#" + templateId).tmpl(eval(data)).appendTo("#" + containerId);
            currentPage++;
            loadingPage = false;
            loadNextPage();
        }
    }

    var loadNextPage = function () {        
        if (readyForNextPage()) {
            //Prevents the page being requested multiple times whilst it is still loading
            loadingPage = true;
            if (loadingContainer)
                $("#" + loadingContainer).show();
            //Build the OData URL
            var url = oDataUrl +
                '?$skip=' + (itemsPerPage * (currentPage - 1)).toString() +
                '&$top=' + itemsPerPage.toString();
            if (sortOrder)
                url += '&$orderby=' + sortOrder;
            console.log(url);
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