const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:14337';

const PROXY_CONFIG = [
  {
    context: [
      //Configure proxy to allow access to api endpoint from angular and ignore angular router route matching
      "/products"
   ],
    target: target,
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    },
    logLevel: 'debug'
  }
]

module.exports = PROXY_CONFIG;
