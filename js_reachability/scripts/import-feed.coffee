# Imports a feed into the API, run with: coffee scripts/import-feed.coffee <url>
request = require 'request'

request process.argv[2], (error, response, body) ->
  throw error if error
  console.log "imported #{body.length} bytes"
