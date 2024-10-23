(function () {
    window.addEventListener("load", function () {
        setTimeout(function () {
            // Section 01 - Set url link
            var logo = document.getElementsByClassName('link');
            logo[0].href = "http://www.wkare.rw/";
            logo[0].target = "_blank";

            // Section 02 - Set logo
            logo[0].children[0].alt = "WK API";
            logo[0].children[0].src = "/img/wk-logo.jpg";

            // Section 03 - Set 32x32 favicon
            var linkIcon32 = document.createElement('link');
            linkIcon32.type = 'image/jpg';
            linkIcon32.rel = 'icon';
            linkIcon32.href = '/img/wk-logo.jpg';
            linkIcon32.sizes = '32x32';
            document.getElementsByTagName('head')[0].appendChild(linkIcon32);

            // Section 03 - Set 16x16 favicon
            var linkIcon16 = document.createElement('link');
            linkIcon16.type = 'image/jpg';
            linkIcon16.rel = 'icon';
            linkIcon16.href = '/img/wk-logo.jpg';
            linkIcon16.sizes = '16x16';
            document.getElementsByTagName('head')[0].appendChild(linkIcon16);
        });
    });
})();