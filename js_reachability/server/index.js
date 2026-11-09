// API server
const express = require('express');
const { sign } = require('./auth');
const { docsPath } = require('./docs');
const { renderReport, fetchFeed } = require('./report');

const app = express();
app.use(express.json());

app.post('/login', (req, res) => res.json({ token: sign({ user: req.body.user }) }));
app.get('/report', async (req, res) => res.send(await renderReport(req.query.md || '# empty')));
app.get('/feed', async (req, res) => res.json(await fetchFeed(req.query.url)));
app.use('/docs', express.static(docsPath()));

app.listen(process.env.PORT || 3000);
