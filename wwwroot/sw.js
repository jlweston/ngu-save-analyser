const version = 'v6';

const expectedCaches = ['static-v6'];

const filesToCache = [
    'Assembly-CSharp.dll',
    '_framework/blazor.boot.json',
    '_framework/blazor.server.js',
    '_framework/blazor.webassembly.js',
    '_framework/wasm/mono.js',
    '_framework/wasm/mono.wasm',
    '_framework/_bin/BlazorInputFile.dll',
    '_framework/_bin/Microsoft.AspNetCore.Blazor.dll',
    '_framework/_bin/Microsoft.AspNetCore.Components.dll',
    '_framework/_bin/Microsoft.AspNetCore.Components.Forms.dll',
    '_framework/_bin/Microsoft.AspNetCore.Components.Web.dll',
    '_framework/_bin/Microsoft.Bcl.AsyncInterfaces.dll',
    '_framework/_bin/Microsoft.Extensions.DependencyInjection.Abstractions.dll',
    '_framework/_bin/Microsoft.Extensions.DependencyInjection.dll',
    '_framework/_bin/Microsoft.Extensions.Logging.Abstractions.dll',
    '_framework/_bin/Microsoft.Extensions.Options.dll',
    '_framework/_bin/Microsoft.Extensions.Primitives.dll',
    '_framework/_bin/Microsoft.JSInterop.dll',
    '_framework/_bin/Mono.Security.dll',
    '_framework/_bin/Mono.WebAssembly.Interop.dll',
    '_framework/_bin/mscorlib.dll',
    '_framework/_bin/netstandard.dll',
    '_framework/_bin/Newtonsoft.Json.dll',
    '_framework/_bin/System.Buffers.dll',
    '_framework/_bin/System.ComponentModel.Annotations.dll',
    '_framework/_bin/System.ComponentModel.Composition.dll',
    '_framework/_bin/System.ComponentModel.DataAnnotations.dll',
    '_framework/_bin/System.Core.dll',
    '_framework/_bin/System.Data.dll',
    '_framework/_bin/System.dll',
    '_framework/_bin/System.Drawing.Common.dll',
    '_framework/_bin/System.IO.Compression.dll',
    '_framework/_bin/System.IO.Compression.FileSystem.dll',
    '_framework/_bin/System.Memory.dll',
    '_framework/_bin/System.Net.Http.dll',
    '_framework/_bin/System.Numerics.dll',
    '_framework/_bin/System.Numerics.Vectors.dll',
    '_framework/_bin/System.Runtime.CompilerServices.Unsafe.dll',
    '_framework/_bin/System.Runtime.Serialization.dll',
    '_framework/_bin/System.ServiceModel.Internals.dll',
    '_framework/_bin/System.Text.Encodings.Web.dll',
    '_framework/_bin/System.Text.Json.dll',
    '_framework/_bin/System.Threading.Tasks.Extensions.dll',
    '_framework/_bin/System.Transactions.dll',
    '_framework/_bin/System.Xml.dll',
    '_framework/_bin/System.Xml.Linq.dll',
    '_framework/_bin/UnityEngine.dll'
];

self.addEventListener('install', event => {
    self.skipWaiting();
    console.log(`${version} installing…`);

    // Cache all files from filesToCache
    event.waitUntil(
        caches.keys()
            .then(keys => Promise.all(
                keys.map(key => {
                    if (!expectedCaches.includes(key)) {
                        return caches.delete(key);
                    }
                })
            )
            .then(() => {
                caches.open(`static-v5`).then(cache => {
                    let requests = filesToCache.map((file) => {
                        console.log(`Fetching ${file}`);
                        return cache.add(file);
                    });

                    return Promise.all(requests)
                        .then(() => console.log("Success!"))
                        .catch((err) => console.log(err))
                })
            })
        )
    );
});

self.addEventListener('activate', event => {
    // delete any caches that aren't in expectedCaches
    // which will get rid of static-v1
    event.waitUntil(
        caches.keys().then(keys => Promise.all(
            keys.map(key => {
                if (!expectedCaches.includes(key)) {
                    return caches.delete(key);
                }
            })
        )).then(() => {
            console.log(`${version} now ready to handle fetches!`);
        })
    );
});

self.addEventListener('fetch', event => {
    const myAPIUrl = 'api.ngusav.es';
    if (event.request.url.indexOf(myAPIUrl) !== -1) { return; }

    event.respondWith(async function () {

        // Try to get the response from a cache.
        const cachedResponse = await caches.match(event.request);
        // Return it if we found one.
        if (cachedResponse) return cachedResponse;

        // If we didn't find a match in the cache, use the network.
        return fetch(event.request);
    }());
});