////var CACHE_NAME = 'my-site-cache-v1';
////var urlsToCache = [
////    '/'
////];

////self.addEventListener('install', function (event) {
////    // Perform install steps
////    console.info('Service Worker Installing...');

////    event.waitUntil(
////        caches.open(CACHE_NAME)
////            .then(function (cache) {
////                console.log('Opened cache');
////                return cache.addAll(urlsToCache);
////            })
////    );

////    console.info('Caching Started...');
////});

////self.addEventListener('fetch', function (event) {
////    event.respondWith(
////        caches.match(event.request)
////            .then(function (response) {
////                // Cache hit - return response
////                if (response) {
////                    return response;
////                }
////                return fetch(event.request);
////            }
////            )
////    );
////});

const cacheName = 'cache-v1';
const dynamicCache = 'dyn-cache-v1';
let urlsToCache = [
    '/',
    '/css/site.css'
];

self.addEventListener('install', (event) => {
    console.info('Service Worker Installing...');

    event.waitUntil(
        caches.open(cacheName)
            .then(function (cache) {
                console.log('Opened cache');
                return cache.addAll(urlsToCache);
            })
    );

    console.info('Caching Started...');
});

self.addEventListener('fetch', function (event) {
    event.respondWith(
        caches.match(event.request)
            .then(function (response) {
                // Cache hit - return response
                if (response) {
                    return response;
                }
                const netResponse = fetch(event.request);
                caches.open(dynamicCache).then((cache) => {
                    // cache.add(event.request);
                });
                return netResponse;
            }
            )
    );
});

self.addEventListener('push', (evt) => {

    let notification = self.registration.showNotification("Check out the privacy!", {
        
    });

    notification.then((args) => { console.log(args); });

    evt.waitUntil(notification);

});