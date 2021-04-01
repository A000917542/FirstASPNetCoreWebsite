// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
if ('caches' in window) {
    const cacheName = 'offlineSaved-v1';
    let offlineBtn = $("#saveForOffline");

    let checkCache = (url, cacheChange = true) => {
        caches.open(cacheName).then((cache) => {
            cache.match(url).then((response) => {
                let match = ('object' == typeof response);
                if (match) {
                    if (cacheChange)
                        cache.delete(window.location.href);

                    if (cacheChange) {
                        offlineBtn.val('💾 Save for offline');
                        offlineBtn.attr('aria-label', 'Save for offline');
                    } else {
                        offlineBtn.val('💾⃠ Remove From cache');
                    }
                    
                } else {
                    if (cacheChange)
                        cache.add(window.location.href);

                    if (cacheChange) {
                        offlineBtn.val('💾⃠ Remove From cache');
                    } else {
                        offlineBtn.val('💾 Save for offline');
                        offlineBtn.attr('aria-label', 'Save for offline');
                    }
                }
            });
        });
    }

    offlineBtn.on("click", () => {
        checkCache(window.location.href);
    });

    checkCache(window.location.href, false);

    offlineBtn.removeAttr('hidden');
}

(async function () {
    if ('Notification' in window) {
        let canAskNotify = false;
        let canNotify = false;

        if ('permissions' in navigator) {
            let permState = await navigator.permissions.query({ name: 'notifications' });
            if (permState.state !== 'denied') {
                canAskNotify = true;
                if (permState.state === 'granted') {
                    canNotify = true;
                }
            }
        } else {
            if (Notification.permission !== 'denied') {
                canAskNotify = true;
                if (Notification.permission === 'granted') {
                    canNotify = true;
                }
            }
        }

        if (canAskNotify && !canNotify) {
            $("#yesNotify").on("click",() => { Notification.requestPermission() });
            $("#noNotify").on("click",() => { $("#askForNotification").hide() });
            $('#sendNotifications').on("click", () => { $("#askForNotification").show() })
            $('#sendNotifications').removeAttr('hidden');
        }
    }
})()

