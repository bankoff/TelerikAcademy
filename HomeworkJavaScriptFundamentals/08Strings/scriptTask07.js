taskName = 'Strings-7';

function Main(bufferElement) {
    var address = "http://www.devbg.org/forum/index.php";

    WriteLine(parseURLAddress(address));
}

function parseURLAddress(address) {
    var protocol = address.substring(0, address.indexOf(":"));
    var server = address.substring(address.indexOf(":") + 3, address.indexOf("/", address.indexOf(":") + 3));
    var resource = address.substr(address.indexOf("/", address.indexOf(":") + 3));
    var testAddress = new BuildAddress(protocol, server, resource);

    return testAddress;
}

function BuildAddress(protocol, server, resource) {
    return {
        protocol: protocol,
        server: server,
        resource: resource,
        toString: function () {
            return "{protocol: '" + this.protocol + "', server: '" + this.server + "', resource: '" + this.resource + "'}";
        }
    };
}