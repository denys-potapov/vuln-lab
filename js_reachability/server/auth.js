// jsonwebtoken is only used through a require() that is not assigned to a variable
const SECRET = process.env.JWT_SECRET || 'dev-secret';

module.exports.sign = (payload) => require('jsonwebtoken').sign(payload, SECRET, { expiresIn: '1h' });
