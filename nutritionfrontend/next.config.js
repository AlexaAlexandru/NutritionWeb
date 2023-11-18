//next.config.js

module.exports = {
    async rewrites() {
        return [{
            source: "/api/:path*",
            destination: "http://localhost:7188/:path*",
        },
        ];
    }
};